using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Unicode(true)]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public double Quantity { get; set; }
        [Precision(10, 2)]
        public decimal Price { get; set; }
      
        public string Description { get; set; }
        public ICollection<Sale> Sales { get; set; }= new List<Sale>();
    }
}
