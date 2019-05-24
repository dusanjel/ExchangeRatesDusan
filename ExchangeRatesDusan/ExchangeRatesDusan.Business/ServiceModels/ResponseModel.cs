using ExchangeRatesDusan.Utils.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRatesDusan.Business.ServiceModels
{
    public class ResponseModel
    {
            public string Base { get; set; }
            public Dictionary<string, Dictionary<string, string>> Rates { get; set; }
            public string End_At { get; set; }
            public string Start_At { get; set; }
    }
}
