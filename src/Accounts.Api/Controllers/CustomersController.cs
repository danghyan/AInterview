using Accounts.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        public CustomersController()
        {
        }
        
        public ActionResult<CurrentAccount> Create(PaymentOrder order)
        {
            // реализовать Api формирования платёжного порученияя.
            return Ok(default);
        }
    }
}