﻿// E-Commerce Inventory Management System

using ConsoleApp.Enums;
using ConsoleApp.Models;
using ConsoleApp.Services;

#region  part 1

/* ElectronicProduct product1 = new ElectronicProduct{

    Id = Guid.NewGuid(),
    Name = "Laptop",
    Price = 1000,
    DefaultWarrantyDurationInDays = TimeSpan.FromDays(365)

};
ElectronicProduct product2 = new ElectronicProduct{

    Id = Guid.NewGuid(),
    Name = "Smartphone",
    Price = 500,
    DefaultWarrantyDurationInDays = TimeSpan.FromDays(365)

};

ClothingProduct product3 = new ClothingProduct{
    Id = Guid.NewGuid(),
    Name = "Shirt",
    Price = 100,
    Size = ClothingSize.S,
    Color = Color.Red,
};

ClothingProduct product4 = new ClothingProduct{
    Id = Guid.NewGuid(),
    Name = "Jeans",
    Price = 200,
    Size = ClothingSize.M,
    Color = Color.Blue,
};

  
Console.WriteLine(product3.ProductDescrpiton());
Console.WriteLine(product4.ProductDescrpiton()); */

#endregion

#region  PART -2

FileService fileService = new();

ClothingProduct product4 = new ClothingProduct{
    Id = Guid.NewGuid(),
    Name = "Jeans",
    Price = 200,
    Size = ClothingSize.M,
    Color = Color.Blue,
};
fileService.SaveTextModel(product4,"/Users/fatos/Desktop/Mext/MextProjects/ConsoleProjects/ConsoleApp/myname.txt");
//product4.Save();
#endregion