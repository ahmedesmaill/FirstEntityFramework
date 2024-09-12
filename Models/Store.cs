using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        [Unicode(true)]
        [MaxLength(80)]
        public string Name { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
