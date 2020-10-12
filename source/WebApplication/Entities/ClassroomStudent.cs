using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class ClassroomStudent : BaseEntity
    {
        public Guid ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

      
    }
}
