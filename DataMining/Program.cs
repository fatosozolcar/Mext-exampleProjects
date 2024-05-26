// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using DataMining.Models;

Console.WriteLine("Hello, World!");

string allText = File.ReadAllText("/Users/fatos/Desktop/Mext/MextProjects/DataMining/Customers.csv");

string[] lines = allText.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (string line in lines.Skip(1)) // Skip the header line
{
    string[] data = line.Split(",");

    if (data.Length != 10) 
    {
        Console.WriteLine($"Warning: Skipping line due to incorrect number of fields: {line}");
        continue;
    }

    try
    {
        Customer customer = new Customer()
        {
            CustomerKey = Convert.ToInt32(data[0]),
            Gender = data[1],
            Name = data[2],
            City = data[3],
            StateCode = data[4],
            State = data[5],
            ZipCode = data[6],
            Country = data[7],
            Continent = data[8],
            Birthday = DateTime.Parse(data[9])
        };

        customers.Add(customer);
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error parsing line: {line}. Exception: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error parsing line: {line}. Exception: {ex.Message}");
    }
}

/* Console.WriteLine("Processed Customers:");
foreach (var customer in customers)
{
    Console.WriteLine($"CustomerKey: {customer.CustomerKey}, Gender: {customer.Gender}, Name: {customer.Name}, City: {customer.City}, StateCode: {customer.StateCode}, State: {customer.State}, ZipCode: {customer.ZipCode}, Country: {customer.Country}, Continent: {customer.Continent}, Birthday: {customer.Birthday.ToShortDateString()}");
} */

var customerDataFromSA = customers.Where(c => c.State == "South Australia");

Console.WriteLine($"CustomerData: {customerDataFromSA.Count()}");

Console.WriteLine();