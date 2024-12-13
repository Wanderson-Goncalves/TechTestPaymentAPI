using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechTestPaymentAPI.src.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProduct { get; set; }

        [Required]
        [StringLength(25)]
        public string? ProductName { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Description cannot exceed 100 characteres")]
        public String? Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}",ApplyFormatInEditMode = true)]
        public decimal Value { get; set; }

        [Required]
        public virtual List<Product> Product { get; set; } = new List<Product>();/*new List<Product>(): Inicializa a lista para evitar NullReferenceException.*/

    }
}