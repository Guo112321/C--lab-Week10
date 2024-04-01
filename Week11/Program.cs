using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Week11.Models.Entities;

class program
{
    public static void Main(string[] args)
    {
        using(var dbContext = new MMABooksContext())
        {
            var customers = dbContext.Customers;
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

    }
}