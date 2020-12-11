using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class DebitCard : BaseCardEntity
    {
        public string Iban { get; set; }
    }
}
