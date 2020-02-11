using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Plant_Life.Data;
using Plant_Life.Models;
using Plant_Life.Models.ViewModel;

namespace Plant_Life.Controllers
{
    public class CalendarsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CalendarsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Calendars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Calendar.Include(c => c.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Calendars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendar
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendar == null)
            {
                return NotFound();
            }

            return View(calendar);
        }

        // GET: Calendars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calendars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationUserId,Id,PlantId,UserPlantId,StartDate,EndDate")] Calendar calendar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calendar);
        }

        // GET: Calendars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendar.FindAsync(id);
            if (calendar == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", calendar.ApplicationUserId);
            return View(calendar);
        }

        // POST: Calendars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationUserId,Id,PlantId,UserPlantId,StartDate,EndDate")] Calendar calendar)
        {
            if (id != calendar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarExists(calendar.Id))
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
            return View(calendar);
        }

        // GET: Calendars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendar
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendar == null)
            {
                return NotFound();
            }

            return View(calendar);
        }

        // POST: Calendars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calendar = await _context.Calendar.FindAsync(id);
            _context.Calendar.Remove(calendar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarExists(int id)
        {
            return _context.Calendar.Any(e => e.Id == id);
        }
        //step1:Get start date and days frequency
        //step2: Find out what day to put the first event on
            //a. find out the difference in days between the today and the startdate
            //b. find remainder given the days frequency
            //c. if the remainder is zero- put the event on today; if it is 1 then put the remainder on the next day.
       //step3: create new event happening every x days from the start day and add as many as you want. 
        public IActionResult GetUserEvents()
        {
            var userId = GetCurrentUserAsync();
            var userEvents = new PlantIndexViewModel();
            try
            {
                userEvents.Events = _context.Event.ToList();
                userEvents.Plants = _context.Plant.Where(e => e.ApplicationUserId == userId.Result.Id).ToList();
                userEvents.DefaultPlantUsers = _context.DefaultPlantUser.Where(e => e.ApplicationUserId == userId.Result.Id)
                    .Include(dp => dp.DefaultPlant).ToList();
            }
            catch(InvalidOperationException) 
            {
                return View("~/Views/Home/Index.cshtml");

            }

       
            return Json(userEvents.Events);
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}
