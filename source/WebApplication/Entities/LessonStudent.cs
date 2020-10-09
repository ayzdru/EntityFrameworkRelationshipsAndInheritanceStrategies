using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class LessonStudent : BaseEntity
    {
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

      
    }
}
