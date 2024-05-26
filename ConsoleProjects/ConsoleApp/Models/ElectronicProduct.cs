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

    /*     public void Save()
        {
            string path = "/Users/fatos/Desktop/Mext/MextProjects/ConsoleProjects/ConsoleApp/myname.txt";

            string content = $"Product Name: {Name}, Product Price: {Price}, warranty: {DefaultWarrantyDurationInDays}";

            File.AppendAllText(path, content);
        }
 */

        /*  public override string ProductDescrpiton()
         {
             return $"Product Name: {Name}, Product Price: {Price}, Warranty: {DefaultWarrantyDurationInDays}";
         } */
    }
}