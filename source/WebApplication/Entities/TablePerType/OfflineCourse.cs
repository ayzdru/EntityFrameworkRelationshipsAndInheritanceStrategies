using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Interfaces;

namespace WebApplication.Entities
{
    public class OfflineCourse : BaseCourse
    {     
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public string Address { get; set; }
    }
}
