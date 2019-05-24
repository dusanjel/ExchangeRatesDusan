using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRatesDusan.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
    }
}
