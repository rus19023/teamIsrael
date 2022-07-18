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

        public MeetingsController(SacramentContext context)
        {
            _context = context;
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

            int pageSize = 10;
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
            var membersList = new List<Member>();
            ViewData["MemberID"] = new SelectList(_context.Members, "ID", "FullName");

            string hymnsJSON = System.IO.File.ReadAllText("Data/LDSHymns2.json");

            var hymns = JsonConvert.DeserializeObject<List<Hymn>>(hymnsJSON) ?? new List<Hymn>();
            
            ViewData["Hymns"] = new SelectList(hymns, "Name", "Name");


            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,MemberID,OpeningHymn,SacramentHymn,ClosingHymn,IntermediateNumber")] Meeting meeting
                                                , int prayer1, int prayer2, ICollection<Participant> speakerParticipants, int numParticipants)
        {
            meeting.Participants = new List<Participant>();
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
                    speakerParticipants.ElementAt(i).MeetingID = meeting.ID;
                    meeting.Participants.Add(speakerParticipants.ElementAt(i));
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberID"] = new SelectList(_context.Members, "ID", "FullName", meeting.MemberID);

            string hymnsJSON = System.IO.File.ReadAllText("Data/LDSHymns2.json");

            var hymns = JsonConvert.DeserializeObject<List<string>>(hymnsJSON);

            ViewData["Hymns"] = new SelectList(hymns, "Value", "Text");
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

            ViewData["MemberID"] = new SelectList(_context.Members, "ID", "FullName", meeting.MemberID);

            string hymnsJSON = System.IO.File.ReadAllText("Data/LDSHymns2.json");

            var hymns = JsonConvert.DeserializeObject<List<string>>(hymnsJSON);
            for (int i = 0; i < hymns.Count(); i++)
            {
                if (hymns[i].Equals(meeting.OpeningHymn))
                {
                    ViewData["OpenHymn"] = new SelectList(hymns,"Value","Text", i);
                }
                else if (hymns[i].Equals(meeting.SacramentHymn))
                {
                    ViewData["SacramentHymn"] = new SelectList(hymns, i);
                }
                else if (hymns[i].Equals(meeting.ClosingHymn))
                {
                    ViewData["CloseHymn"] = new SelectList(hymns, i);
                }
            }
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
            //Original Template code
            /*
            if (id != meeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }*/

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

            ViewData["MemberID"] = new SelectList(_context.Members, "ID", "FirstName", meetingToUpdate.MemberID);

            string hymnsJSON = System.IO.File.ReadAllText("Data/LDSHymns2.json");

            var hymns = JsonConvert.DeserializeObject<List<string>>(hymnsJSON);
            for (int i = 0; i < hymns.Count(); i++)
            {
                if (hymns[i].Equals(meetingToUpdate.OpeningHymn))
                {
                    ViewData["OpenHymn"] = new SelectList(hymns, i);
                }
                else if (hymns[i].Equals(meetingToUpdate.SacramentHymn))
                {
                    ViewData["SacramentHymn"] = new SelectList(hymns, i);
                }
                else if (hymns[i].Equals(meetingToUpdate.ClosingHymn))
                {
                    ViewData["CloseHymn"] = new SelectList(hymns, i);
                }
            }
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

        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.ID == id);
        }
    }
}
