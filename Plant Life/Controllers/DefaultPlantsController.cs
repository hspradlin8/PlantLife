using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Plant_Life.Data;
using Plant_Life.Models;

namespace Plant_Life.Controllers
{
 [Authorize]
    public class DefaultPlantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DefaultPlantsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: DefaultPlants
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            return View(await _context.DefaultPlant.ToListAsync());
        }

        // GET: DefaultPlants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defaultPlant = await _context.DefaultPlant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (defaultPlant == null)
            {
                return NotFound();
            }

            return View(defaultPlant);
        }

        // GET: DefaultPlants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DefaultPlants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlantName,Sunlight,Temperature,WaterNeeds,Description,Issues,Quantity,Image")] DefaultPlant defaultPlant)
        {

            if (ModelState.IsValid)
            {
                _context.Add(defaultPlant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(defaultPlant);
        }

        // POST: AddDefaultPlants
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDefaultPlant(int id)
        {
            var user = await GetCurrentUserAsync();
            var defaultPlantUser = new DefaultPlantUser
            {
                ApplicationUserId = user.Id,
                DefaultPlantId = id,
                Image = null

            };


            _context.Add(defaultPlantUser);


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), "Plants");
        }

        // GET: DefaultPlants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defaultPlant = await _context.DefaultPlant.FindAsync(id);
            if (defaultPlant == null)
            {
                return NotFound();
            }
            return View(defaultPlant);
        }

        // POST: DefaultPlants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlantName,Sunlight,Temperature,WaterNeeds,Description,Issues,Quantity,Image")] DefaultPlant defaultPlant)
        {
            if (id != defaultPlant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(defaultPlant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DefaultPlantExists(defaultPlant.Id))
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
            return View(defaultPlant);
        }

        // GET: DefaultPlants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defaultPlant = await _context.DefaultPlant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (defaultPlant == null)
            {
                return NotFound();
            }

            return View(defaultPlant);
        }

        // POST: DefaultPlants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var defaultPlant = await _context.DefaultPlant.FindAsync(id);
            _context.DefaultPlant.Remove(defaultPlant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DefaultPlantExists(int id)
        {
            return _context.DefaultPlant.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
