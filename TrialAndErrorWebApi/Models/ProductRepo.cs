using System.Collections.Generic;
using System.Linq;

namespace TrialAndErrorWebApi.Models
{
    public class ProductRepo
    {
        public static List<Product> listOfProducts = new List<Product>();
        public static object myLock = new object();
        public static void PopulateList()
        {
            Product A = new Product { Id = 1, Name = "ABD", Category = "123", Price = 12.22M };
            Product B = new Product { Id = 2, Name = "dddd", Category = "123", Price = 122.22M };
            Product C = new Product { Id = 3, Name = "wwww", Category = "123", Price = 132.22M };

            listOfProducts.Add(A);
            listOfProducts.Add(B);
            listOfProducts.Add(C);
        }

        public static string Add(int id, string name, string category, decimal price)
        {
            lock (myLock)
            {
                string message = "Create";
                listOfProducts.Add(new Product(id, name, category, price));
                return message;

            }
        }

        public static List<Product> GetAllProducts()
        {
            PopulateList();
            return listOfProducts.ToList();
        }

        public static Product GetProductById(int ID)
        {
            lock (myLock)
            {
                PopulateList();
                Product _product = new Product();
                _product = null;
                foreach (Product product in listOfProducts)
                {
                    if (product.Id == ID)
                    {
                        _product = product;
                    }
                }
                return _product;
            }
        } 
    }
}