using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Lesson : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Bire çok ilişki
        public Teacher TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //Çok çok ilişki
        private readonly List<LessonStudent> _lessonStudents = new List<LessonStudent>();
        public IReadOnlyCollection<LessonStudent> LessonStudents => _lessonStudents.AsReadOnly();
    }
}
