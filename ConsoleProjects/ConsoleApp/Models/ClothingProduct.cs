using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Enums;
using ConsoleApp.Models.Common;

namespace ConsoleApp.Models
{
    public class ClothingProduct:ProductBase,IDescription
    {
        public ClothingSize Size { get; set; }

        public Color Color { get; set; }

        public string ProductDescrpiton()
        {
            return $"Product Name: {Name}, Product Price: {Price}, Color: {Color}, Size: {Size}";
        }

        



        /*   public override string ProductDescrpiton()
          {
              return $"Product Name: {Name}, Product Price: {Price}, Color: {Color}, Size: {Size}";
          } */
    }
}