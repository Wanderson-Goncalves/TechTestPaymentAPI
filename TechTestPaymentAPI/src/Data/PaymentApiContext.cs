using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechTestPaymentAPI.src.Entities;

namespace TechTestPaymentAPI.src.Data
{
    public class PaymentApiContext : DbContext
    {
        public PaymentApiContext(DbContextOptions<PaymentApiContext> options) : base(options)
        { }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SellerSale> SellerSale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurar a tabela de junção 
            modelBuilder.Entity<SellerSale>()
                .HasOne(ss => ss.Seller)
                .WithMany(s => s.SellerSales)
                .HasForeignKey(ss => ss.idSeller);

            modelBuilder.Entity<SellerSale>()
                .HasOne(ss => ss.Sale)
                .WithMany(s => s.SellerSales)
                .HasForeignKey(ss => ss.idSale);
        }

    }
}