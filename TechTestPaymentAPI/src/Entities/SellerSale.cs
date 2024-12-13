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
        [ForeignKey("idSeller")]
        public int idSeller { get; set; }


        [Required]
        [Column("idSale")]
        [ForeignKey("idSale")]
        public int idSale { get; set; }
        public object Seller { get; internal set; }
    }
}