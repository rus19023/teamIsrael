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
            var meetings = from m  in _context.Meetings
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

            var hymns = JsonConvert.DeserializeObject<List<string>>(hymnsJSON);
            ViewData["Hymns"] = new SelectList(hymns);


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

            IEnumerable<int> prayers =
                meeting.Participants.Where(p => p.IsPraying.Equals(true)).Select(p => p.MemberID);

            IEnumerable<int> speakers =
                meeting.Participants.Where(p => p.IsPraying.Equals(false)).Select(p => p.MemberID);

            for (int i = 0; i < prayers.Count(); i++)
            {
                ViewData[$"Prayer{(i + 1)}"] = new SelectList(_context.Members, "ID", "FullName", prayers.ElementAt(i));
            }

            for (int i = 0; i < speakers.Count(); i++)
            {
                ViewData[$"Speaker{i}"] = new SelectList(_context.Members, "ID", "FullName", speakers.ElementAt(i));
            }

            ViewData["MemberGeneral"] = new SelectList(_context.Members, "ID", "FullName");

            ViewData["MemberID"] = new SelectList(_context.Members, "ID", "FullName", meeting.MemberID);
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,MemberID,OpeningHymn,SacramentHymn,ClosingHymn,IntermediateNumber")] Meeting meeting)
        {
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
            }
            ViewData["MemberID"] = new SelectList(_context.Members, "ID", "FirstName", meeting.MemberID);
            return View(meeting);
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
