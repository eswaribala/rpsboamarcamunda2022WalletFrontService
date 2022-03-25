using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalletFrontService.Repository;

namespace WalletFrontService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private WalletMongoRepository _walletMongoRepository; 
        public WalletController(WalletMongoRepository walletMongoRepository)
        {
            this._walletMongoRepository = walletMongoRepository;

        }
        [HttpGet("Wallets")]
        public IActionResult Get()
        {
            return Ok(this._walletMongoRepository.GetWallets());
        }

    }
}
