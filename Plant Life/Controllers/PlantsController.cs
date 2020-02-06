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
        public async Task<IActionResult> Create([Bind("Id,PlantName,PlantCare,Quantity,Image,File")] Plant plant, IFormFile file)
        {
            var user = await GetCurrentUserAsync();
            plant.ApplicationUserId = user.Id;


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

            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", plant.ApplicationUserId);
            return View(plant);
        }

        // POST: Plants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationUserId,Id,PlantName,PlantCare,Quantity,Image,File")] Plant plant, IFormFile file)
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
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", plant.ApplicationUserId);
            return View(plant);
        }


        // GET: Plants/Delete/5
        public async Task<IActionResult> Delete(int? id)
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
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUser, "Id", "Id", plant.ApplicationUserId);
            return View(plant);
        }

        // POST: Plants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plant = await _context.Plant.FindAsync(id);
            _context.Plant.Remove(plant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantExists(int id)
        {
            return _context.Plant.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
