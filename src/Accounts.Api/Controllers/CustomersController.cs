using Accounts.Api.Models;
using Accounts.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Accounts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        
        public ActionResult<CurrentAccount> Create(PaymentOrder order)
        {
            try
            {
                _customerService.PaymentTransfer(order);
                return Ok(default);
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}