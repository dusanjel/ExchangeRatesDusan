using ExchangeRatesDusan.Domain.Interfaces;
using ExchangeRatesDusan.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRatesDusan.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExchangeRatesDusanContext _context;
        
        public UnitOfWork(ExchangeRatesDusanContext context)
        {
            _context = context;  
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
