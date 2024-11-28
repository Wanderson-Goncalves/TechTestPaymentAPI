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
        public int idSale {get; set;}

        [Required]

        [ForeignKey("Seller")]
        public int idSeller {get; set;}

        [Required]
        public Seller? Seller {get; set;}

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime SaleDate {get; set;}

        [EnumDataType(typeof(Status))]
        public Status Status {get; set;} = Status.AwaitingPayment;

    }
}