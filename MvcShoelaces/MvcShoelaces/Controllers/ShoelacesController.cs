using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcShoelaces.Data;
using MvcShoelaces.Models;

namespace MvcShoelaces.Controllers
{
    public class ShoelacesController : Controller
    {

        // GET: Shoelaces
        public IActionResult Index()
        {
            return View(SeedData.Shoelaces);
        }

        // GET: Shoelaces/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoelaces = SeedData.Shoelaces.FirstOrDefault(m => m.Id == id);
            if (shoelaces == null)
            {
                return NotFound();
            }

            return View(shoelaces);
        }

        // GET: Shoelaces/Create
        public IActionResult Create()
        {
            ViewBag.Colors = new List<SelectListItem>
            {
                new SelectListItem {Text = "Red", Value = "Red"},
                new SelectListItem {Text = "Yellow", Value = "Yellow"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
                new SelectListItem {Text = "Blue", Value = "Blue"},
                new SelectListItem {Text = "White", Value = "White"},
                new SelectListItem {Text = "Black", Value = "Black"},
                new SelectListItem {Text = "Pink", Value = "Pink"},
                new SelectListItem {Text = "Brown", Value = "Brown"}
            };

            ViewBag.Brand = new List<SelectListItem>
            {
                new SelectListItem {Text = "Golf", Value = "Golf"},
                new SelectListItem {Text = "Sperry", Value = "Sperry"},
                new SelectListItem {Text = "Thorogood", Value = "Thorogood"},
                new SelectListItem {Text = "ECCO", Value = "ECCO"}
            };
            return View();
        }

        // POST: Shoelaces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Brand,Color,Length,Cost,Rating")] Shoelaces shoelaces)
        {
            shoelaces.Id = Guid.NewGuid().ToString();
            shoelaces.CreatedDate = DateTime.Now;
            shoelaces.ModifiedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                SeedData.Shoelaces.Add(shoelaces);
                return RedirectToAction(nameof(Index));
            }
            return View(shoelaces);
        }

        // GET: Shoelaces/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoelaces = SeedData.Shoelaces.FirstOrDefault(m => m.Id == id);
            if (shoelaces == null)
            {
                return NotFound();
            }
            ViewBag.Colors = new List<SelectListItem>
            {
                new SelectListItem {Text = "Red", Value = "Red"},
                new SelectListItem {Text = "Yellow", Value = "Yellow"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
                new SelectListItem {Text = "Blue", Value = "Blue"},
                new SelectListItem {Text = "White", Value = "White"},
                new SelectListItem {Text = "Black", Value = "Black"},
                new SelectListItem {Text = "Pink", Value = "Pink"},
                new SelectListItem {Text = "Brown", Value = "Brown"}
            };

            ViewBag.Brand = new List<SelectListItem>
            {
                new SelectListItem {Text = "Golf", Value = "Golf"},
                new SelectListItem {Text = "Sperry", Value = "Sperry"},
                new SelectListItem {Text = "Thorogood", Value = "Thorogood"},
                new SelectListItem {Text = "ECCO", Value = "ECCO"}
            };
            return View(shoelaces);
        }

        // POST: Shoelaces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind("Id,Brand,Color,Length,Cost,Rating,CreatedDate")] Shoelaces shoelaces)
        {
            shoelaces.ModifiedDate = DateTime.Now;
            if (id != shoelaces.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var updatedShoelaces = SeedData.Shoelaces.FirstOrDefault(m => m.Id == id);
                    updatedShoelaces.Length = shoelaces.Length;
                    updatedShoelaces.Rating = shoelaces.Rating;
                    updatedShoelaces.Cost = shoelaces.Cost;
                    updatedShoelaces.Brand = shoelaces.Brand;
                    updatedShoelaces.Color = shoelaces.Color;
                    updatedShoelaces.ModifiedDate = shoelaces.ModifiedDate;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoelacesExists(shoelaces.Id))
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
            return View(shoelaces);
        }

        // GET: Shoelaces/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoelaces = SeedData.Shoelaces.FirstOrDefault(m => m.Id == id);
            if (shoelaces == null)
            {
                return NotFound();
            }

            return View(shoelaces);
        }

        // POST: Shoelaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var shoelaces = SeedData.Shoelaces
               .FirstOrDefault(m => m.Id == id);
            if (shoelaces != null)
                SeedData.Shoelaces.Remove(shoelaces);
            return RedirectToAction(nameof(Index));
        }

        private bool ShoelacesExists(string id)
        {
            return SeedData.Shoelaces.Any(e => e.Id == id);
        }
    }
}
