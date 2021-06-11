using System.Collections.ObjectModel;
using Accounts.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        public AccountsController()
        {
        }

        public ActionResult<Collection<CurrentAccount>> Get()
        {
            return Ok(default);
        }
        
        public ActionResult<CurrentAccount> Get(string number)
        {
            // реализовать Api получения счёта по идентификатору
            return Ok(default);
        }

        public ActionResult<Collection<CurrentAccount>> Get(Customer customer)
        {
            // реализовать Api получения счетов клиента
            return Ok(default);
        }
    }
}