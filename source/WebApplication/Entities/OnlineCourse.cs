using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Interfaces;

namespace WebApplication.Entities
{
    public class OnlineCourse : BaseEntity, ICourse
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public string Url { get; set; }
    }
}
