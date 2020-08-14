using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Create([Bind("Id,Title,Description,")] TestModel testModel)
        {
            if (ModelState.IsValid)
            {
              //  _testService.Add.ToString((testModel.Description, testModel.ImageName));
      
              
                return RedirectToAction(nameof(Index));
            }
            return View(testModel);
        }

     
    }


}
