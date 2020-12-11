using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;
using WebApplication.Interfaces;

namespace WebApplication.Entities
{
    public class Course : BaseCourse
    {
       

        //Bire çok ilişki
        private readonly List<OnlineCourse> _onlineCourses = new List<OnlineCourse>();
        public IReadOnlyCollection<OnlineCourse> OnlineCourses => _onlineCourses.AsReadOnly();


        //Bire çok ilişki
        private readonly List<OfflineCourse> _offlineCourses = new List<OfflineCourse>();
        public IReadOnlyCollection<OfflineCourse> OfflineCourses => _offlineCourses.AsReadOnly();
    }
}
