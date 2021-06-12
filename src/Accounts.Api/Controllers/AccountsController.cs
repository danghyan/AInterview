using System.Collections.ObjectModel;
using Accounts.Api.BL;
using Accounts.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountProvider _accountProvider;
        public AccountsController(IAccountProvider accountProvider)
        {
            _accountProvider = accountProvider;
        }
        [HttpGet]
        public ActionResult<Collection<CurrentAccount>> Get()
        {
           var result = _accountProvider.GetAllAccounts();
            if (!(result is null))
                return Ok(result);
            else
                return  new EmptyResult();
        }
        [HttpGet]
        public ActionResult<CurrentAccount> Get(string number)
        {
            var result = _accountProvider.GetCurrentAccount(number);
            return Ok(result);
        }
        [HttpGet]
        public ActionResult<Collection<CurrentAccount>> Get(Customer customer)
        {
            var result = _accountProvider.GetCurrentAccount(customer);
            return Ok(result);
        }

        //GetBalance => config count of  .
    }
}