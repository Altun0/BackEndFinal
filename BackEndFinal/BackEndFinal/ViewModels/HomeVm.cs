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
        public List<NoticeBoard> noticeBoards { get; set; }
        public List<NoticeRight> noticeRights { get; set; }
        public ViewCourse viewcourses{ get; set; }
        public courseweoffer courseweoffer { get; set; }
        public List<row> rows { get; set; }
        public uppcomingevent uppcomingevent { get; set; }
        public List<workshop> workshops { get; set; }
        public testimonial testimonial { get; set; }
        public List<blogdetails> blogdetails { get; set; }


    }
}
