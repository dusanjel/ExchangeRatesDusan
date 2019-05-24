using ExchangeRatesDusan.Business.Help;
using ExchangeRatesDusan.Business.Interfaces;
using ExchangeRatesDusan.Business.ServiceModels;
using ExchangeRatesDusan.Utils.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesDusan.Business.Services
{
    public class ExchangeRatesService : IExchangeRatesService
    {
        public async Task<decimal> AverageExchangeRateDuringPeriod(RequestModel requestModel)
        {
            string url = $"https://api.exchangeratesapi.io/history?base={ requestModel.CurrencyPair.BaseCurrency }&start_at={ requestModel.DateRange.StartDate }&end_at={ requestModel.DateRange.EndDate }&symbols={ requestModel.CurrencyPair.TargetCurrency }";
            var result = await ApiProxy.GetAsync(url);
            var ratesList = ResultToList(result);
            return ratesList.Average();
        }

        public async Task<decimal> MaximumExchangeRateDuringPeriod(RequestModel requestModel)
        {
            string url = $"https://api.exchangeratesapi.io/history?base={ requestModel.CurrencyPair.BaseCurrency }&start_at={ requestModel.DateRange.StartDate }&end_at={ requestModel.DateRange.EndDate }&symbols={ requestModel.CurrencyPair.TargetCurrency }";
            var result = await ApiProxy.GetAsync(url);
            var ratesList = ResultToList(result);
            return ratesList.Max();
        }

        public async Task<decimal> MinimumExchangeRateDuringPeriod(RequestModel requestModel)
        {
            string url = $"https://api.exchangeratesapi.io/history?base={ requestModel.CurrencyPair.BaseCurrency }&start_at={ requestModel.DateRange.StartDate }&end_at={ requestModel.DateRange.EndDate }&symbols={ requestModel.CurrencyPair.TargetCurrency }";
            var result = await ApiProxy.GetAsync(url);
            var ratesList = ResultToList(result);
            return ratesList.Min();
        }

        private static List<decimal> ResultToList(ResponseModel result)
        {
            List<decimal> ratesList = new List<decimal>();
            foreach (var rate in result.Rates)
            {
                foreach (var item in rate.Value)
                {
                    var r = item.Value;
                    ratesList.Add(System.Convert.ToDecimal(r));
                }
            }
            return ratesList;
        }
    }
}
