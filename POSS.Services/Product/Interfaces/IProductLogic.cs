using POSS.Models.Product;
using POSSModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace POSS.Services.Interfaces
{
    public interface IProductLogic
    {
        public String Add_Product(ProductModel model);
        public ProductModel FindProductById(int Id);
        public List<ProductModel> GetProducts();
        public String DeleteProduct(int Id);
        public ProductModel UpdateProduct(ProductModel model);
        public bool ProductExists(int id);
      
    }
}
