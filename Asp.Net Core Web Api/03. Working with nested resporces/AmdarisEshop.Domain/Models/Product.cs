using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisEshop.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProdcutDescription { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
