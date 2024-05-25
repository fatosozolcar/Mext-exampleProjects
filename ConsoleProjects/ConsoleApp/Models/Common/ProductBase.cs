using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Models.Common
{
    public abstract class ProductBase 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

    
    }

}