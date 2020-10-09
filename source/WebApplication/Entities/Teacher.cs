using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Teacher : BasePersonEntity
    {
        //Bire çok ilişki
        private readonly List<Lesson> _lessons = new List<Lesson>();
        public IReadOnlyCollection<Lesson> Lessons => _lessons.AsReadOnly();
    }
}
