using System.ComponentModel.DataAnnotations;

namespace WebAss.Models
{
    public class Estore
    {
        [Key]
        public string productName { get; set; }
        public string productID { get; set; }
        public string product_price { get; set; }
    }
}