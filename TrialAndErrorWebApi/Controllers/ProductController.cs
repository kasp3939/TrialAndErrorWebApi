using System.Collections.Generic;
using System.Web.Http;
using TrialAndErrorWebApi.Models;

namespace TrialAndErrorWebApi.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> AddProduct()
        {
            return AddProduct();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return GetAllProducts();
        }

        public IEnumerable<Product> GetProductById()
        {
            return GetProductById();
        }
    }
}
