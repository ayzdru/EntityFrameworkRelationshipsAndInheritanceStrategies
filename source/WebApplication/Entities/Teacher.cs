using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Teacher : BasePersonEntity
    {
        //Bire çok ilişki
        private readonly List<Classroom> _classrooms = new List<Classroom>();
        public IReadOnlyCollection<Classroom> Classrooms => _classrooms.AsReadOnly();
    }
}
