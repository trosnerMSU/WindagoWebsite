using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindagoWebApplication.Models {
    public class InventoryItem {
        [Key]
        [ForeignKey("INVID")]
        public int Id { get; set; }
        public string Description { get; set; }
        public string PartNo { get; set; }
        [StringLength(12)]
        public int UPC { get; set; }
        public string Color { get; set; }
        [DataType(DataType.Currency)]
        public decimal MfgCost { get; set; }
        [DataType(DataType.Currency)]
        public decimal SellingPrice { get; set; }
        public decimal Weight { get; set; }
        public int AvailStockQty { get; set; }
        public int BackOrderQty { get; set; }
        public string ImageDirectoryLoc { get; set; } //This will be the directory path for the image of the product that lives on the web server so that we can display it to the client
        public bool isActive { get; set; }
    }
}
