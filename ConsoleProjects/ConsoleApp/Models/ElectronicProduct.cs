using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Models.Common;

namespace ConsoleApp.Models
{
    public class ElectronicProduct:ProductBase, IDescription
    {
        public TimeSpan DefaultWarrantyDurationInDays { get; set; }

        public string ProductDescrpiton()
        {
            return $"Product Name: {Name}, Product Price: {Price}, Warranty: {DefaultWarrantyDurationInDays}";
        }


        /*  public override string ProductDescrpiton()
         {
             return $"Product Name: {Name}, Product Price: {Price}, Warranty: {DefaultWarrantyDurationInDays}";
         } */
    }
}