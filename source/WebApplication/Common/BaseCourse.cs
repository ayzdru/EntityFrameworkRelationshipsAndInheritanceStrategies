using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Entities
{
    public abstract class BaseCourse : BaseEntity
    {
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
