using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTestPaymentAPI.src.Data;
using TechTestPaymentAPI.src.Entities;
using TechTestPaymentAPI.src.Interfaces;

namespace TechTestPaymentAPI.src.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly PaymentApiContext _context;
        public SaleRepository(PaymentApiContext context)
        {
            _context = context;
        }

        public void IncluideSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void SelectSaleID(int id)
        {
            throw new NotImplementedException();
        }
        
        public Task<IEnumerable<Sale>> ListAllSales()
        {
            throw new NotImplementedException();
        }

        public void Deletesale(int id)
        {
            throw new NotImplementedException();
        }
    }
}