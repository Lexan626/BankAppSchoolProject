using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankAppInlämming.Services.Interfaces;
using BankAppInlämming.Models;
namespace BankAppInlämming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        [Route("GetAllTransactions/{id}")]
        public IActionResult GetTransaction(int id)
        {
            try
            {
                if (id <= 0) return BadRequest("Invalid data");
                return Ok(_transactionService.GetAllTransactions(id));
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [Route("AddTransaction")]
        public IActionResult PostTransaction(Models.Transaction transaction)
        {
            try
            {
                if (transaction == null) return BadRequest("Invalid data");

                _transactionService.AddTransaction(transaction);
                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
