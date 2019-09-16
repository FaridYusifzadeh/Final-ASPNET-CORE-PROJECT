using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using indecor_web_site.DAL;
using indecor_web_site.Models;
using Microsoft.AspNetCore.Mvc;

namespace indecor_web_site.Areas.IndecorAdmin.Controllers
{
    [Area("IndecorAdmin")]
    public class DescriptionController : Controller
    {
        private IndecorDbContext _context;
        public DescriptionController(IndecorDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Descriptions);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Description skill = await _context.Descriptions.FindAsync(id);

            if (skill == null) return NotFound();

            return View(skill);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Description skill)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _context.Descriptions.AddAsync(skill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }





        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Description skill = await _context.Descriptions.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Description skill = await _context.Descriptions.FindAsync(id);
            _context.Descriptions.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }





        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Description skill = await _context.Descriptions.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Description skill)
        {
            //WhatWeDo dbSkill = await _context.WhatWeDos.FindAsync(id);
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            //dbSkill.Title = skill.Title;
            //dbSkill.Description = skill.Description;
            //await _context.SaveChangesAsync();

            _context.Entry(skill).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }

}