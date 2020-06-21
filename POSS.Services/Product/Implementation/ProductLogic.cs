using POSS.DataAccess;
using POSS.DataAccess.Context;
using POSS.DataAccess.ProductModels;
using POSS.Models.Product;
using POSS.Services.Interfaces;
using POSSModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace POSS.Services.Implementation
{
    public class ProductLogic : IProductLogic
    {
        private readonly POSSDbContext dbContext;


        public ProductLogic(POSSDbContext context)
        {
            dbContext = context;
        }
        public string Add_Product(ProductModel model)
        {
            try
            {
                using (dbContext)
                {
      
                    var product = new Product
                    {
                        Id = model.Id,
                        Name = model.Name,
                        Description = model.Description,
                        Group = model.Group,
                        SubGroup = model.SubGroup,
                        Image = model.Image,
                        Price = Convert.ToDouble(model.Price.ToString()),
                        Quantity = model.Quantity,
                        Status = "InStock",
                        CreatedBy = "Prince Lunga",
                        DateCreated = DateTime.Now,
                        Discount = model.Discount,
                        Vat = model.Vat
                    };

                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                    return "Product Successfully Added";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }

        public string DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public ProductModel FindProductById(int Id)
        {
           using(dbContext)
            {
                return dbContext.Products.Select(x => new ProductModel 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Group = x.Group,
                    SubGroup = x.SubGroup,
                    Status = x.Status,
                    Description = x.Description,
                    Image = x.Image,
                    Price = x.Price,
                    Quantity = x.Quantity
                    
                }).SingleOrDefault( b => b.Id == Id);
             }
        }

        public List<ProductModel> GetProducts()
        {
            using (dbContext)
            {
                return dbContext.Products.Select(x => new ProductModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Group = x.Group,
                    SubGroup = x.SubGroup,
                    Image = x.Image,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    Status = x.Status

                }).ToList();
            }
        }

        public ProductModel UpdateProduct(ProductModel model)
        {
            using(dbContext)
            {
                var product = dbContext.Products.Find(Convert.ToInt32(model.Id));

                if(product != null)
                {
                    product.Id = Convert.ToInt32(model.Id);
                    product.Name = model.Name;
                    product.Group = model.Group;
                    product.SubGroup = model.SubGroup;
                    product.Status = model.Status;
                    product.ModifiedBy = "Current User";
                    product.Price = Convert.ToDouble(model.Price);
                    product.Quantity = Convert.ToInt32(model.Quantity);
                    product.DateModified = DateTime.Now;
                    product.Description = model.Description;

                   // dbContext.Products.
                    dbContext.SaveChanges();
                    return model;
                }
                else
                {
                    return model;
                }
            }
        }

        public bool ProductExists(int id)
        {
            using(dbContext)
            {
                var product = dbContext.Products.Where(x => x.Id == id);
                if(product != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

       
    }
}
