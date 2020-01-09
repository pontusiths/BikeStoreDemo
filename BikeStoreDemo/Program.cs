using BikeStoreDemo.Models;
using System;
using System.Linq;

namespace BikeStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeStoreContext = new BikeStores2Context();
            
            foreach (var item in bikeStoreContext.Customers)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }
        }
    }
}
