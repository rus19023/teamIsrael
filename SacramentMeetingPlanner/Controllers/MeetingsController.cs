using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;
using System;

namespace SacramentMeetingPlanner.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly SacramentContext _context;
        private readonly List<Hymn> hymns;

        public MeetingsController(SacramentContext context)
        {
            _context = context;
            string hymnsJSON = System.IO.File.ReadAllText("Data/LDSHymnsKV.json");

            hymns = JsonConvert.DeserializeObject<List<Hymn>>(hymnsJSON) ?? new List<Hymn>();
        }

        // GET: Meetings
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var meetings = from m  in _context.Meetings.Include(m => m.Member)
                           select  m;
            if (!String.IsNullOrEmpty(searchString))
            {
                meetings = meetings.Where(s => s.Member.FullName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Date":
                    meetings = meetings.OrderBy(s => s.MeetingDate);
                    break;
                case "date_desc":
                    meetings = meetings.OrderByDescending(m => m.MeetingDate);
                    break;
                default:
                    meetings = meetings.OrderBy(s => s.MeetingDate);
                    break;
            }

            int pageSize = 9;
            return View(await PaginatedList<Meeting>.CreateAsync(meetings.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
   

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.Member)
                .Include(m => m.Participants.OrderByDescending(p => p.IsPraying).ThenBy(p => p.Order))
                    .ThenInclude(p => p.Member)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            
            List<Member> leaderList = _context.Members.Where(m => m.IsLeader.Equals(true)).ToList();

            ViewData["MemberID"] = new SelectList(leaderList, "ID", "FullName");

            ViewData["Members"] = new SelectList(_context.Members, "ID", "FullName");

            ViewData["Hymns"] = new SelectList(hymns, "Name", "Name");


            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,MemberID,OpeningHymn,SacramentHymn,ClosingHymn,IntermediateNumber")] Meeting meeting
                                                , int prayer1, int prayer2, ICollection<Participant>? speakerParticipants, int numParticipants)
        {
            meeting.Participants = new List<Participant>();
            for (int i = 0; i < 2; i++)
            {
                int memberID;
                if (i == 0)
                {
                    if (prayer1 == -1)
                    {
                        ModelState.AddModelError("Prayer1", "Prayer participant was left unselected.");
                        ViewData["Prayer1Error"] = "Please select a member for this prayer.";
                        break;
                    }
                    memberID = prayer1;
                }
                else
                {
                    if (prayer2 == -1)
                    {
                        ModelState.AddModelError("Prayer2", "Prayer participant was left unselected.");
                        ViewData["Prayer2Error"] = "Please select a member for this prayer.";
                        break;
                    }
                    memberID = prayer2;
                }

                meeting.Participants.Add(new Participant
                {
                    MeetingID = meeting.ID,
                    MemberID = memberID,
                    IsPraying = true,
                    Order = i
                });
                
            }

            if (numParticipants > 0)
            {
                for (int i = 0; i < numParticipants; i++)
                {
                    //Checks that a speaker was selected given that Please Choose One option has a value of -1
                    if (speakerParticipants.ElementAt(i).MemberID == -1)
                    {
                        ModelState.AddModelError("SpeakerID", "Speaker was not selected.");
                        ViewData["SpeakerError"] = "Please select a speaker.";
                        break;
                    }
                    //Checks that topic was not left empty
                    if (String.IsNullOrWhiteSpace(speakerParticipants.ElementAt(i).Topic))
                    {
                        ModelState.AddModelError("Topic", "Topic can not be empty.");
                        ViewData["TopicError"] = "Please enter a topic for the speaker.";
                        break;
                    }
                    speakerParticipants.ElementAt(i).MeetingID = meeting.ID;
                    meeting.Participants.Add(speakerParticipants.ElementAt(i));
                }
            }

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(meeting);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                ModelState.AddModelError("", "Unable to save changes. " +
                                             "Try again, and if the problem persists, " +
                                             "see your system administrator.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                ViewData["Error"] =
                    "!!A member can only participate as a speaker/prayer assignment once. Please don't duplicate members " +
                    "on participation assignments!!";
            }

            List<int> speakerIDs = new List<int>();
            if (numParticipants > 0)
            {
                for (int i = 0; i < numParticipants; i++)
                {
                    speakerIDs.Add(speakerParticipants.ElementAt(i).MemberID);
                }
            }

            ViewData["SpeakerIDs"] = speakerIDs;
            ViewData["Context"] = _context;
            ViewData["Prayer1"] = new SelectList(_context.Members, "ID", "FullName", prayer1);
            ViewData["Prayer2"] = new SelectList(_context.Members, "ID", "FullName", prayer2);
            ViewData["Members"] = new SelectList(_context.Members, "ID", "FullName");

            List<Member> leaderList = _context.Members.Where(m => m.IsLeader.Equals(true)).ToList();
            ViewData["MemberID"] = new SelectList(leaderList, "ID", "FullName");

            ViewData["Hymns"] = new SelectList(hymns, "Name", "Name");
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.Participants)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            

            if (meeting == null)
            {
                return NotFound();
            }

            IEnumerable<int> prayersID =
                meeting.Participants.Where(p => p.IsPraying.Equals(true)).OrderBy(p => p.Order)
                    .Select(p => p.MemberID);

            IEnumerable<int> speakersID =
                meeting.Participants.Where(p => p.IsPraying.Equals(false)).OrderBy(p => p.Order)
                    .Select(p => p.MemberID);
            List<int> indexes = new List<int>();

            foreach (var speakerID in speakersID)
            {
                int index = getParticipantIndex(speakerID, meeting, false);
                indexes.Add(index);
            }

            ViewData["Indexes"] = indexes;

            for (int i = 0; i < prayersID.Count(); i++)
            {
                ViewData[$"Prayer{(i + 1)}"] = new SelectList(_context.Members, "ID", "FullName", prayersID.ElementAt(i));
            }

            ViewData["Context"] = _context;

            ViewData["SpeakerNumber"] = speakersID.Count();

            ViewData["MemberGeneral"] = new SelectList(_context.Members, "ID", "FullName");

            List<Member> leaderList = _context.Members.Where(m => m.IsLeader.Equals(true)).ToList();
            ViewData["MemberID"] = new SelectList(leaderList, "ID", "FullName", meeting.MemberID);
            
            ViewData["OpenHymn"] = new SelectList(hymns, "Name", "Name", meeting.OpeningHymn);
            ViewData["SacramentHymn"] = new SelectList(hymns, "Name", "Name", meeting.SacramentHymn);
            ViewData["CloseHymn"] = new SelectList(hymns, "Name", "Name", meeting.ClosingHymn);
            return View(meeting);
        }
        
        // POST: Meetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, /*[Bind("ID,MeetingDate,MemberID,OpeningHymn,SacramentHymn,ClosingHymn,IntermediateNumber")] Meeting meeting
                                            ,*/ int prayer1, int prayer2, ICollection<Participant> speakerParticipants, int numParticipants)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var meetingToUpdate = await _context.Meetings
                .Include(m => m.Participants)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (await TryUpdateModelAsync<Meeting>(
                    meetingToUpdate,
                    "",
                    m => m.MeetingDate, m => m.MemberID, m => m.OpeningHymn, m => m.SacramentHymn,
                    m => m.IntermediateNumber, m => m.ClosingHymn))
            {
                updateParticipants(meetingToUpdate, prayer1, prayer2, speakerParticipants, numParticipants);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    Console.WriteLine(ex.Message);
                    ModelState.AddModelError("", "Unable to save changes. " +
                                                 "Try again, and if the problem persists, " +
                                                 "see your system administrator.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    ViewData["Error"] =
                        "!!A member can only participate as a speaker/prayer assignment once. Please don't duplicate members " +
                        "on participation assignments!!";
                }
                return RedirectToAction(nameof(Index));
            }
            
            //Sets all the ViewDatas needed in the View to dynamically set the dropdown lists
            IEnumerable<int> prayersID =
                meetingToUpdate.Participants.Where(p => p.IsPraying.Equals(true)).OrderBy(p => p.Order)
                    .Select(p => p.MemberID);

            IEnumerable<int> speakersID =
                meetingToUpdate.Participants.Where(p => p.IsPraying.Equals(false)).OrderBy(p => p.Order)
                    .Select(p => p.MemberID);
            List<int> indexes = new List<int>();

            foreach (var speakerID in speakersID)
            {
                int index = getParticipantIndex(speakerID, meetingToUpdate, false);
                indexes.Add(index);
            }

            ViewData["Indexes"] = indexes;

            for (int i = 0; i < prayersID.Count(); i++)
            {
                ViewData[$"Prayer{(i + 1)}"] = new SelectList(_context.Members, "ID", "FullName", prayersID.ElementAt(i));
            }

            ViewData["Context"] = _context;

            ViewData["SpeakerNumber"] = speakersID.Count();

            ViewData["MemberGeneral"] = new SelectList(_context.Members, "ID", "FullName");

            List<Member> leaderList = _context.Members.Where(m => m.IsLeader.Equals(true)).ToList();
            ViewData["MemberID"] = new SelectList(leaderList, "ID", "FirstName", meetingToUpdate.MemberID);

            ViewData["OpenHymn"] = new SelectList(hymns, "Name", "Name", meetingToUpdate.OpeningHymn);
            ViewData["SacramentHymn"] = new SelectList(hymns, "Name", "Name", meetingToUpdate.SacramentHymn);
            ViewData["CloseHymn"] = new SelectList(hymns, "Name", "Name", meetingToUpdate.ClosingHymn);
            return View(meetingToUpdate);
        }

        private void updateParticipants(Meeting meetingToUpdate, int prayer1, int prayer2, ICollection<Participant> speakers, int numParticipants)
        {
            /* UPDATE PRAYER PARTICIPANTS
             * In case elements get disordered in database, I store the prayer participants in a separate list ordered by
             * Order Number stored. Then if the corresponding submitted Member ID value does not match the current stored one
             * it will look for the index of the one to change in the actual Participants collection linked to the meeting and
             * update it. If no changes, no updates occur.
             */
            List<Participant> originalPrayers = meetingToUpdate.Participants.Where(p => p.IsPraying == true)
                .OrderBy(p => p.Order)
                .ToList();
            for (int i = 0; i < 2; i++)
            {
                int memberID;
                if (i == 0)
                {
                    memberID = prayer1;
                }
                else
                {
                    memberID = prayer2;
                }

                if (originalPrayers[i].MemberID != memberID)
                {
                    _context.Remove(originalPrayers[i]);
                    meetingToUpdate.Participants.Add(new Participant
                    {
                        MeetingID = meetingToUpdate.ID,
                        MemberID = memberID,
                        IsPraying = true,
                        Order = i
                    });
                }
            }

            //UPDATE SPEAKER PARTICIPANTS
            List<Participant> originalSpeakers = meetingToUpdate.Participants.Where(p => p.IsPraying == false)
                .OrderBy(p => p.Order)
                .ToList();
            //If original speakers is Null or empty and this remained true in the update, then we just skip the process
            //of looking for differences to update or add speakers and exit out of method.
            if (!originalSpeakers.Any() && numParticipants == 0)
            {
                return;
            }
            //If no participants were selected in update, which at this point means they meant to remove all speakers
            //we iterate through speakers and remove them all.
            if (numParticipants == 0)
            {
                foreach (var speaker in originalSpeakers)
                {
                    _context.Remove(speaker);
                }
            }
            else
            {
                //Here we check if there were more original speakers than current speakers. If so, that means
                //some were removed and we iterate through them and remove all removed speakers.
                if (originalSpeakers.Count() > numParticipants)
                {
                    for (int i = 0; i < originalSpeakers.Count(); i++)
                    {
                        if (i >= numParticipants)
                        {
                            _context.Remove(originalSpeakers[i]);
                        }
                    }
                }
                //Iterate through the number of participants to update or add new speakers
                for (int i = 0; i < numParticipants; i++)
                {
                    //Checks that topics were not left empty or with only whitespaces.
                    if (String.IsNullOrWhiteSpace(speakers.ElementAt(i).Topic))
                    {
                        ModelState.AddModelError("Topic", "Topic can not be empty.");
                        ViewData["TopicError"] = "Please enter a topic for the speaker.";
                        return;
                    }

                    //Here we check if the current speaker (in order) is still part of the original speakers
                    //and if so check for differences and update.
                    if (i < originalSpeakers.Count())
                    {
                        if (originalSpeakers[i].MemberID != speakers.ElementAt(i).MemberID)
                        {
                            _context.Remove(originalSpeakers[i]);
                            speakers.ElementAt(i).MeetingID = meetingToUpdate.ID;
                            meetingToUpdate.Participants.Add(speakers.ElementAt(i));
                        }
                        else if (!originalSpeakers[i].Topic.Equals(speakers.ElementAt(i).Topic))
                        {
                            int index = getParticipantIndex(originalSpeakers[i].MemberID, meetingToUpdate, false);
                            meetingToUpdate.Participants.ElementAt(index).Topic = speakers.ElementAt(i).Topic;
                        }
                    }
                    //If past the original speakers, add new speaker to Participant table.
                    else
                    {
                        speakers.ElementAt(i).MeetingID = meetingToUpdate.ID;
                        meetingToUpdate.Participants.Add(speakers.ElementAt(i));
                    }
                }
            }
        }

        //Return Index of the correct Participant in case they get stored in incorrect order
        private int getParticipantIndex(int memberID, Meeting meetingToUpdate, bool praying)
        {
            int index = 0;
            if (praying)
            {
                foreach (var participant in meetingToUpdate.Participants)
                {
                    if (participant.MemberID == memberID && participant.IsPraying)
                    {
                        return index;
                    }

                    index++;
                }
            }
            else
            {
                foreach (var participant in meetingToUpdate.Participants)
                {
                    if (participant.MemberID == memberID && !participant.IsPraying)
                    {
                        return index;
                    }

                    index++;
                }
            }

            return -1;
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.Member)
                .Include(m => m.Participants.OrderByDescending(p => p.IsPraying).ThenBy(p => p.Order))
                    .ThenInclude(p => p.Member)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // GET: Meetings/PrintProgram/5
        public async Task<IActionResult> PrintProgram(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var meeting = await _context.Meetings
                .Include(m => m.Member)
                .Include(m => m.Participants.OrderByDescending(p => p.IsPraying).ThenBy(p => p.Order))
                .ThenInclude(p => p.Member)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }
        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.ID == id);
        }
        
        
    }
}
