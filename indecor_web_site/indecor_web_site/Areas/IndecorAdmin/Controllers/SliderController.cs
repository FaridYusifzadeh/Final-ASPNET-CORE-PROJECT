using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using indecor_web_site.DAL;
using indecor_web_site.Extentions;
using indecor_web_site.Models;
using indecor_web_site.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace indecor_web_site.Areas.IndecorAdmin.Controllers
{
    [Area("IndecorAdmin")]
    public class SliderController : Controller
    {
        private IndecorDbContext _context;
        private IHostingEnvironment _env;

        public SliderController(IndecorDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public IActionResult Index()
        {

            return View(_context.Sliders);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Slider slider = await _context.Sliders.FindAsync(id);

            if (slider == null) return NotFound();

            return View(slider);

        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                || ModelState["Description"].ValidationState == ModelValidationState.Invalid
                || ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil novunu duz secin");
                return View();
            }
            if (!slider.Photo.CheckImageSize(2))
            {
                ModelState.AddModelError("Photo", "Shekil hecmi coxdur");
                return View();
            }


            string filename = await slider.Photo.CopyImage(_env.WebRootPath, "slider");

            slider.Image = filename;
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Slider delete = await _context.Sliders.FindAsync(id);

            if (delete == null) return NotFound();

            return View(delete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null)
            {
                return RedirectToAction(nameof(Index));
            }

            Utility.DeleteImgFromFolder(_env.WebRootPath, slider.Image);

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            Slider sliderDb = await _context.Sliders.FindAsync(id);

            if (sliderDb == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid
                || ModelState["Description"].ValidationState == ModelValidationState.Invalid)
            {
                return View(sliderDb);
            }

            if (slider.PhotoUpdate != null)
            {
                if (!slider.PhotoUpdate.IsImage())
                {
                    ModelState.AddModelError("Photo", "Content type must be image");
                    return View();
                }

                if (!slider.PhotoUpdate.CheckImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Image size not more than 2 Mb");
                    return View();
                }

                string filename = await slider.PhotoUpdate.CopyImage(_env.WebRootPath, "slider");
                Utility.DeleteImgFromFolder(_env.WebRootPath, sliderDb.Image);

                sliderDb.Image = filename;
            }

            sliderDb.Title = slider.Title;
            sliderDb.Description = slider.Description;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}