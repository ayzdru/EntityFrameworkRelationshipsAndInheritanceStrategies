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
        private readonly List<ClassroomStudent> _classroomStudents = new List<ClassroomStudent>();
        public IReadOnlyCollection<ClassroomStudent> ClassroomStudents => _classroomStudents.AsReadOnly();

    }
}
