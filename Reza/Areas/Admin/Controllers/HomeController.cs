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
        IEducationService _education;
        public HomeController(IEducationService education)
        {
            _education = education;
        }


        public IActionResult Index()
        {
            return View(_education.GetAllEducation());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Education education)
        {
            _education.InsertEducation(education);
            return View(education);
        }


    }
}
