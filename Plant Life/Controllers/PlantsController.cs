using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Plant_Life.Data;
using Plant_Life.Models;
using Plant_Life.Models.ViewModel;

namespace Plant_Life.Controllers
{
    [Authorize]
    public class PlantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PlantsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Plants
        public async Task<IActionResult> Index()
        {
            //CreateEventsForPlant(new Plant() { Description = "Times A Month" });
            var plantIndexViewModel = new PlantIndexViewModel();
            var user = await GetCurrentUserAsync();
            plantIndexViewModel.Plants = _context.Plant.Where(a => a.ApplicationUserId == user.Id).ToList();
            plantIndexViewModel.DefaultPlantUsers = _context.DefaultPlantUser
                .Where(a => a.ApplicationUserId == user.Id).Include(a => a.DefaultPlant).ToList();
            return View(plantIndexViewModel);
        }

        // GET: Plants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.Plant
                .Include(p => p.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        // GET: Plants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlantName,Sunlight,Temperature,Water,WaterNeeds,Description,Issues,Quantity,Image,File")] Plant plant, IFormFile file)
        {
            var user = await GetCurrentUserAsync();
            plant.ApplicationUserId = user.Id;
            CreateEventsForPlant(plant);

            if (plant.File != null && plant.File.Length > 0)
            {
                var fileName = Path.GetFileName(plant.File.FileName); //getting path of actual file name
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", fileName); //creating path combining file name w/ www.root\\images directory
                using (var fileSteam = new FileStream(filePath, FileMode.Create)) //using filestream to get the actual path 
                {
                    await plant.File.CopyToAsync(fileSteam);
                }
                plant.Image = fileName;
            }

            if (ModelState.IsValid)
            {
                _context.Add(plant);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plant);
        }

        // GET: Plants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.Plant.FindAsync(id);
            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        // GET: EditUserDefault/Edit/5
        public async Task<IActionResult> EditUserDefault(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.DefaultPlant

                .FirstOrDefaultAsync(dp => dp.Id == id);
            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        // POST: Plants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationUserId,Id,PlantName,Sunlight,Temperature,Water,WaterNeeds,Description,Issues,Quantity,Image,File")] Plant plant, IFormFile file)
        {

            if (id != plant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (plant.File != null && plant.File.Length > 0)
                    {
                        var fileName = Path.GetFileName(plant.File.FileName); //getting path of actual file name
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", fileName); //creating path combining file name w/ www.root\\images directory
                        using (var fileSteam = new FileStream(filePath, FileMode.Create)) //using filestream to get the actual path 
                        {
                            await plant.File.CopyToAsync(fileSteam);
                        }
                        plant.Image = fileName;
                    }
                    _context.Update(plant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantExists(plant.Id))
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
            return View(plant);
        }


        // POST: Plants.EditUserDefault/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Step 1. delete correct defaultplantuser record
        //Step 2. save a new record in the plant table
        public async Task<IActionResult> EditUserDefault(int id, [Bind("Id,PlantName,Sunlight,Temperature,Water,WaterNeeds,Description,Issues,Quantity,Image,File")] DefaultPlant defaultPlant, IFormFile file)
        {

            if (id != defaultPlant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = await GetCurrentUserAsync();
                    var deleteDefaultPlantUser = await _context.DefaultPlantUser
                         .Include(dp => dp.DefaultPlant)
                         .FirstOrDefaultAsync(dp => dp.DefaultPlantId == id && dp.ApplicationUserId == currentUser.Id);

                    if (deleteDefaultPlantUser == null)
                    {
                        return NotFound();
                    }

                    var plant = new Plant
                    {
                        ApplicationUserId = currentUser.Id,
                        PlantName = defaultPlant.PlantName,
                        Sunlight = defaultPlant.Sunlight,
                        Temperature = defaultPlant.Temperature,
                        Water = defaultPlant.Water,
                        WaterNeeds = defaultPlant.WaterNeeds,
                        Description = defaultPlant.Description,
                        Issues = defaultPlant.Issues,
                        Quantity = defaultPlant.Quantity,
                        Image = defaultPlant.Image
                    };

                    _context.Add(plant);
                    _context.Remove(deleteDefaultPlantUser);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantExists(defaultPlant.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(defaultPlant);
        }


        // GET: Plants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.Plant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plant == null)
            {
                return NotFound();
            }
            return View(plant);
        }

        // GET: DefaultPlants/Delete/5
        public async Task<IActionResult> DeleteDefaultPlant(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.DefaultPlantUser
                .Include(p => p.ApplicationUser).Include(dp => dp.DefaultPlant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plant == null)
            {
                return NotFound();
            }
            return View(plant);
        }

        // POST: Plants/Delete/5
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plant = await _context.Plant.FindAsync(id);
            _context.Plant.Remove(plant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // POST: DefaultPlants/Delete/5
        [HttpPost, ActionName("DeleteDefaultPlantConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDefaultPlantConfirmed(int id)
        {
            var plant = await _context.DefaultPlantUser.FindAsync(id);
            _context.DefaultPlantUser.Remove(plant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantExists(int id)
        {
            return _context.Plant.Any(e => e.Id == id);
        }

        private void CreateEventsForPlant(Plant plant)
        {
            switch (plant.Description)
            {
                //case "Times A Week":
                //int Timesperweek = plant.WaterNeeds;
                //int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                //int dayOfMonth = DateTime.Now.Day;
                //int DaysLeftInMonth = daysInMonth - dayOfMonth;
                //int daysLeftInCurrentWeek = DaysLeftInMonth % 7;
                //int weeksLeftInCurrentMonth = DaysLeftInMonth / 7;
                //DateTime NextWeek = DateTime.Now.AddDays(daysLeftInCurrentWeek + 1);
                //NextWeek.

                case "Times A Month":
                    List<DateTime> WaterDates = new List<DateTime>();
                    int TimesperMonth = plant.WaterNeeds;
                    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    int dayOfMonth = DateTime.Now.Day;
                    int DaysLeftInMonth = daysInMonth - dayOfMonth;
                    int WaterDayCount = DaysLeftInMonth / TimesperMonth; //3


                    for (int i = 0; i <= TimesperMonth; i++)
                    {
                        WaterDates.Add(DateTime.Now.AddDays(WaterDayCount * i));
                    }

                    //for each water date in WaterDates we need to add an event
                    //create a loop and iterate through water events and create a new event
                    //object with the plant Id and the Waterdate as the startdate with any other info we need
                    var user = GetCurrentUserAsync();

                    for (int i = 0; i < WaterDates.Count; i++)
                    {
                        Event newWaterEvent = new Event()
                        {
                            ApplicationUserId = user.Result.Id,
                            EventName = plant.PlantName,
                            Plant = plant,
                            StartDate = WaterDates[i]
                        };

                        _context.Add(newWaterEvent);

                    }

                    var x = 0;
                    break;

                case null:
                    break;
                default:
                    break;
            }
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
