using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creative.Model.Model;

namespace Creative.Repository.IRepository
{
    public interface IDiscountRepository
    {
        bool Delete(int id);
        Discount GetById(int id);
        Discount Insert(Discount entity);
        IList<Discount> GetAll();
        void Update(Discount entity);
    }
}
