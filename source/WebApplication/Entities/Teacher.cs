using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Teacher : BasePersonEntity
    {
        //Bire çok ilişki
        public ICollection<Course> Courses { get; set; }
    }
}
