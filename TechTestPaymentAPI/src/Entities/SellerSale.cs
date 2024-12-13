using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTestPaymentAPI.src.Entities
{
    [Table("SellerSale")]
    public class SellerSale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idSellerSale")]
        public int idSellerSale { get; set; }
        [Required]
        [Column("idSeller")]
        public int idSeller { get; set; }
        [ForeignKey("idSeller")]
        public Seller Seller { get; set; }
        [Required]
        [Column("idSale")]
        public int idSale { get; set; }

        [ForeignKey("idSale")]
        public Sale Sale { get; set;}


    }
}