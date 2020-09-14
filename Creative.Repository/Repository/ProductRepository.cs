using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Creative.Model.Model;
using Creative.Repository.IRepository;

namespace Creative.Repository
{
    public class ProductRepository : IProductRepository
    {

       
        public ProductRepository()
        {
           
        }

        public bool Delete(int id)
        {
            try
            {
                using (var _dataContext = new CreativeEntities())
                {
                    Product product = _dataContext.Products.Find(id);
                  
                    if (product != null)
                    {
                        _dataContext.Products.Remove(product);
                        _dataContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch(Exception e)
            {
                return false;
            }

        }




        public Product GetById(int id)
        {
            using (var _dataContext = new CreativeEntities())
            {
                return _dataContext.Products.Find(id);
            }
        }


        public Product Insert(Product entity)
        {
            using (var _dataContext = new CreativeEntities())
            {
                Product Product = _dataContext.Products.Add(entity);
                _dataContext.SaveChanges();
                return Product;
            }
        }

        public IList<Product> GetAll()
        {
            using (var _dataContext = new CreativeEntities())
            {
                var data = _dataContext.Products.Where(x=>x.IsActive).ToList();
                return data;
            }
        }

        public void Update(Product entity)
        {
            using (var _dataContext = new CreativeEntities())
            {
                var original = _dataContext.Products.FirstOrDefault(e => e.ProductId.Equals(entity.ProductId));
                if (original != null)
                {
                    _dataContext.Entry(original).CurrentValues.SetValues(entity);
                    _dataContext.SaveChanges();

                }

            }
        }
        
    }
}
