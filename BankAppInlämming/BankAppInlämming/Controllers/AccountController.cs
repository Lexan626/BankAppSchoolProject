using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankAppInlämming.Services.Interfaces;
using BankAppInlämming.Models;

namespace BankAppInlämming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }



        [HttpGet]
        [Route("GetAccount/{CustumerID}")]
        public IActionResult Get(int CustumerID)
        {
            try
               {
                if (CustumerID == null) return BadRequest("Invalid data");
               
                return Ok(_accountService.GetAccounts(CustumerID));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("GetAccountTypes")]
        public IActionResult GetTypes()
        {
            try
            {
                var model = _accountService.GetAllAccountsTypes();
                return Ok(_accountService.GetAllAccountsTypes());
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("addAccount")]
        public IActionResult Post(Account account)
        {
            try
            {
                if (account == null) return BadRequest("Invalid data");


                return Ok(_accountService.AddAccount(account));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
