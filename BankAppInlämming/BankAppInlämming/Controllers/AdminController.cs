using BankAppInlämming.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankAppInlämming.Models;

namespace BankAppInlämming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult PostCustomer(Customer customer)
        {
            try
            {
                
                if (customer == null) return BadRequest("Invalid data");

             
                return Ok(_adminService.AddCustomer(customer.Namn));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [Route("AddLoan")]
        public IActionResult PostLoan(Loan loan)
        {
           
            try
            {
                if (loan == null) return BadRequest("Invalid data");

                ;
                return Ok(_adminService.AddLoan(loan));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("AddAccountType")]
        public IActionResult PostAccountType(AccountType accountType)
        {
            try
            {
                if (accountType == null) return BadRequest("Invalid data");

                
                return Ok(_adminService.AddAcountType(accountType));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
