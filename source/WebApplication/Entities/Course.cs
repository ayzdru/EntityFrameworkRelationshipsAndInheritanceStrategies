using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Bire çok ilişki
        public Teacher TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //Çok çok ilişki
        public ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
