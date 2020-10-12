using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Classroom : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Bire çok ilişki
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //Çok çok ilişki
        private readonly List<ClassroomStudent> _classroomStudents = new List<ClassroomStudent>();
        public IReadOnlyCollection<ClassroomStudent> ClassroomStudents => _classroomStudents.AsReadOnly();
    }
}
