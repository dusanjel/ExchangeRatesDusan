using ExchangeRatesDusan.Utils.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRatesDusan.Business.ServiceModels
{
    public class RequestModel
    {
        public CurrencyPair CurrencyPair { get; set; }
        public DateRange DateRange { get; set; }
    }
}
