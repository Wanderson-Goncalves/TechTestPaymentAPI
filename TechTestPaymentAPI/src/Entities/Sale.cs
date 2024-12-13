using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTestPaymentAPI.src.Entities
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idSale")]
        public int idSale {get; set;}

        [Required]
        [Column("idSeller")]
        [ForeignKey("Seller")]
        public int idSeller {get; set;}

        [Required]
        [Column("Seller")]
        [StringLength(50)]
        public Seller? Seller {get; set;}

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column("SaleDate")]
        public DateTime SaleDate {get; set;}

        [EnumDataType(typeof(Status))]
        [Column("Status")]
        public Status Status {get; set;} = Status.AwaitingPayment;

        public virtual ICollection<Product>? Products {get; set;}
        public virtual ICollection<SellerSale> SellerSales {get; set;}

        

    }
}