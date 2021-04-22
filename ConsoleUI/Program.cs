using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var p in productManager.GetByCategoryId(2))
            {
                Console.WriteLine("ID: {0} | Name: {1}", p.ProductID, p.ProductName);
            }
        }
    }
}
