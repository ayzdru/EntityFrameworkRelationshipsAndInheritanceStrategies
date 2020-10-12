using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class CreditCard : BaseCardEntity
    {
        public decimal TotalEarnedPoint { get; set; }
        public bool IsVirtual { get; set; }
    }
}
