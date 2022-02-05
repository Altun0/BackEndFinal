using BackEndFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinal.ViewModels
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public SlidersDesc SlidersDesc { get; set; }
    }
}
