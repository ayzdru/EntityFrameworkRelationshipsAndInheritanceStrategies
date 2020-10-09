using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public abstract class BasePersonEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
