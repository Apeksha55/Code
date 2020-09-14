using Creative.Model.Model;
using System.Collections.Generic;

namespace Creative.Repository.IRepository
{
    public interface IProductRepository
    {
        bool Delete(int id);
        Product GetById(int id);
        Product Insert(Product entity);
        IList<Product> GetAll();
        void Update(Product entity);
    }
}
