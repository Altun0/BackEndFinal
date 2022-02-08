using BackEndFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinal.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {


        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> noticeBoards   { get; set; }
        public DbSet<NoticeRight> noticeRights { get; set; }
        public DbSet<ViewCourse> viewCourses  { get; set; }
        public DbSet<courseweoffer> courseweoffers { get; set; }
        public DbSet<row> rows { get; set; }
        public DbSet<uppcomingevent> uppcomingevents { get; set; }
        public DbSet<workshop> workshops { get; set; }
        public DbSet<testimonial> testimonials { get; set; }
        public DbSet<blogdetails> blogdetails { get; set; }


    }
}


