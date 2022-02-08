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
           

            HomeVm homeVm = new HomeVm
            {
                Sliders= _context.Sliders.ToList(),
                noticeBoards=_context.noticeBoards.ToList(),
                noticeRights=_context.noticeRights.ToList(),
                viewcourses=_context.viewCourses.FirstOrDefault(),
                courseweoffer=_context.courseweoffers.FirstOrDefault(),
                rows=_context.rows.ToList(),
                uppcomingevent=_context.uppcomingevents.FirstOrDefault(),
                workshops=_context.workshops.ToList(),
                testimonial=_context.testimonials.FirstOrDefault(),
                blogdetails=_context.blogdetails.ToList()


                
            };

                return View(homeVm);
        }
    }
}
