using ExchangeRatesDusan.Business.ServiceModels;
using ExchangeRatesDusan.Utils.Support;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesDusan.Business.Interfaces
{
    public interface IExchangeRatesService
    {
        Task<decimal> MaximumExchangeRateDuringPeriod(RequestModel requestModel);
        Task<decimal> MinimumExchangeRateDuringPeriod(RequestModel requestModel);
        Task<decimal> AverageExchangeRateDuringPeriod(RequestModel requestModel);
    }
}
