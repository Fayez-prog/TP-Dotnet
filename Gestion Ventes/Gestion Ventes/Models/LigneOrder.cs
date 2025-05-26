using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Ventes.Models
{
    public class LigneOrder
    {
        [Key]
        public int LigneOrderID { get; set; }

        [Required]
        public int OrderQty { get; set; }

        public decimal LineltemTotal { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
