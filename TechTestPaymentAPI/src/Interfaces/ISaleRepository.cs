using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTestPaymentAPI.src.Entities;

namespace TechTestPaymentAPI.src.Interfaces
{
    public interface ISaleRepository
    {
        void IncluideSale (Sale sale);
        void SelectSaleID(int id);
        Task<IEnumerable<Sale>>ListAllSales();
        void Deletesale(int id);


    }
}