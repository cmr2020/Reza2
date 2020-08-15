using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reza.Core.Services.Interfaces;
using Reza.DataLayer.Entitis;

namespace Reza.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        public IActionResult Index()
        {
            return View(_testService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,")] TestModel testModel,IFormFile img)
        {
            if (ModelState.IsValid)
            {
               _testService.Add(testModel,img);
      
              
                return RedirectToAction(nameof(Index));
            }
            return View(testModel);
        }



        public IActionResult Edit(int? id)
        {

            var test = _testService.GetById(id.Value);


            return View(test);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,")] TestModel testModel, IFormFile img)
        {
            _testService.Edit(testModel, img);
          


            return View(testModel);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var test2 = _testService.GetById(id.Value);
            return View(test2);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(TestModel test)
        {
            _testService.Delete(test);
          
            return RedirectToAction(nameof(Index));

        }


        }

  



}
