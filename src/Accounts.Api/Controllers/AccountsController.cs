using System;
using System.Collections.ObjectModel;
using System.Linq;
using Accounts.Api.DB;
using Accounts.Api.Models;
using Accounts.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountsController(AccountService accountService)
        {
            _accountService = accountService;
        }

        public ActionResult<Collection<CurrentAccount>> Get()
        {
            var accounts = _accountService.GetAllAccounts();

            if (accounts != null)
            {
                return Ok(accounts);
            }
            return new EmptyResult();
        }
        
        [HttpGet]
        public ActionResult<CurrentAccount> Get(string number)
        {
            var account = _accountService.GetCurrentAccount(number);

            if (account != null)
            {
                return Ok(account);
            }
            return new EmptyResult();
        }

        public ActionResult<Collection<CurrentAccount>> Get(Customer customer)
        {
            var accounts = _accountService.GetCurrentAccounts(customer.Id);
            return Ok(accounts);
        }
    }
}