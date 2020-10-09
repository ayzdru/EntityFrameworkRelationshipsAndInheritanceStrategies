using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Student : BasePersonEntity
    {
        //Bire bir ilişki     
        public StudentAddress StudentAddress { get; set; }
        //Çok çok ilişki
        public ICollection<CourseStudent> CourseStudents { get; set; }

    }
}
