using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Data;
using WebApplication.Entities;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _applicationDbContext;
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public void OnGet()
        {
            //_applicationDbContext.Cards.Add(new CreditCard() { FirstName = "Ayaz", LastName = "Duru", Cvc = 222, Number = 5140215804319220, ExpiryMonth = 10, ExpiryYear = 2020, TotalEarnedPoint = 100 });
            //_applicationDbContext.Cards.Add(new DebitCard() { FirstName = "Ayaz", LastName = "Duru", Cvc = 222, Number = 5140215804319220, ExpiryMonth = 10, ExpiryYear = 2020, Iban = "TR850006264518651427951562" });
            //_applicationDbContext.SaveChanges();
                
        }
    }
}
