using BackEndFinal.DAL;
using BackEndFinal.Models;
using BackEndFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<int> sliders = _context.Sliders.Select(x=> x.Id).ToList();
            SlidersDesc sliderDesc = _context.SlidersDescs.FirstOrDefault();
            HomeVm homeVm = new HomeVm();
            //homeVm.Sliders = sliders;
            homeVm.SlidersDesc = sliderDesc;
            return View(homeVm);
        }
    }
}
