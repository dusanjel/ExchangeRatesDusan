using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeRatesDusan.Utils.Support;
using Microsoft.AspNetCore.Mvc;
using ExchangeRatesDusan.Business.ServiceModels;
using ExchangeRatesDusan.Business.Interfaces;
//using ExchangeRatesDusan.Business.Interfaces;
//using ExchangeRatesDusan.Business.ServiceModels;

namespace ExchangeRatesDusan.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        private readonly IExchangeRatesService exchangeRatesService;

        public ExchangeRatesController(IExchangeRatesService exchangeRatesService)
        {
            this.exchangeRatesService = exchangeRatesService;
        }

        [Route("MaximumExchangeRateDuringPeriod")]
        [HttpPost]
        public ActionResult<decimal> MaximumExchangeRateDuringPeriod([FromBody] RequestModel requestModel)
        {
            var task = exchangeRatesService.MaximumExchangeRateDuringPeriod(requestModel);
            return task.Result;
        }

        [Route("MinimumExchangeRateDuringPeriod")]
        [HttpPost]
        public ActionResult<decimal> MinimumExchangeRateDuringPeriod([FromBody] RequestModel requestModel)
        {
            var task = exchangeRatesService.MinimumExchangeRateDuringPeriod(requestModel);
            return task.Result;
        }

        [Route("AverageExchangeRateDuringPeriod")]
        [HttpPost]
        public ActionResult<decimal> AverageExchangeRateDuringPeriod([FromBody] RequestModel requestModel)
        {
            var task = exchangeRatesService.AverageExchangeRateDuringPeriod(requestModel);
            return task.Result;
        }
    }
}
