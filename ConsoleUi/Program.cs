using System;
using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUi
{
    class Program   
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager( new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
