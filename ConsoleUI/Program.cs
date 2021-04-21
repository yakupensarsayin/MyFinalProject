using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine("ID: {0} | Name: {1}", p.ProductID, p.ProductName);
            }
        }
    }
}
