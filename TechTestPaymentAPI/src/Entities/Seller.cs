using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTestPaymentAPI.src.Entities
{
    [Table("Seller")]
    public class Seller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("idSaller")]
        public int idSeller { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "The name must contain only letters and spaces")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters")]
        [Column("Name,")]
        public string? Name { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "CPF field must contain only 12 numbers")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "The CPF must be in the format XXX.XXX.XXX-XX and contain only numbers")]
        [Column("CPF")]
        public string? CPF { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [Column("Email")]
        public string? Email { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}[-]?\d{4}$", ErrorMessage = "The phone must be in the format (XX)XXXXX-XXXX or similar")]
        [Column("Phone")]
        public string? Telephone { get; set; }

        public virtual ICollection<SellerSale> SellerSales {get; set;}
    }
}