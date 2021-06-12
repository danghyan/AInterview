using Accounts.Api.BL;
using Accounts.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IAccountProvider _accountProvider;
        
        public CustomersController(IAccountProvider accountProvider)
        {
            _accountProvider = accountProvider;
        }
        [HttpPost]
        public ActionResult<CurrentAccount> Create(PaymentOrder order)
        {
            _accountProvider.AddNewPaymentOrder(order);
            return Ok(default);
        }
    }
}