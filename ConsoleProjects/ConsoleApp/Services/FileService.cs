using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Models.Common;

namespace ConsoleApp.Services
{
    public class FileService
    {
        public void SaveTextModel(IDescription model, string fileName){

             string path = "/Users/fatos/Desktop/Mext/MextProjects/ConsoleProjects/ConsoleApp/myname.txt";

            string content = $"{model.ProductDescrpiton()}\n";

            File.AppendAllText(path, content);

           

        }
    }
}