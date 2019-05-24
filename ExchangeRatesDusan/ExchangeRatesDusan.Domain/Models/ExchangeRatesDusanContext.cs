using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRatesDusan.Domain.Models
{
    public class ExchangeRatesDusanContext : DbContext
    {
        public ExchangeRatesDusanContext(DbContextOptions<ExchangeRatesDusanContext> options)
            : base(options)
        { }
    }
}
