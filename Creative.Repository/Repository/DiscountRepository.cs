using Creative.Model.Model;
using Creative.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Repository.Repository
{
   public class DiscountRepository : IDiscountRepository
    {


        public DiscountRepository()
        {

        }

        public bool Delete(int id)
        {
            try
            {
                using (var _dataContext = new CreativeEntities())
                {
                    Discount discount = _dataContext.Discounts.Find(id);

                    if (discount != null)
                    {
                        _dataContext.Discounts.Remove(discount);
                        _dataContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception e)
            {
                return false;
            }

        }




        public Discount GetById(int id)
        {
            using (var _dataContext = new CreativeEntities())
            {
                return _dataContext.Discounts.Find(id);
            }
        }


        public Discount Insert(Discount entity)
        {
            using (var _dataContext = new CreativeEntities())
            {
                Discount discount = _dataContext.Discounts.Add(entity);
                _dataContext.SaveChanges();
                return discount;
            }
        }

        public IList<Discount> GetAll()
        {
            using (var _dataContext = new CreativeEntities())
            {
                var data = _dataContext.Discounts.ToList();
                return data;
            }
        }

        public void Update(Discount entity)
        {
            using (var _dataContext = new CreativeEntities())
            {
                var original = _dataContext.Discounts.FirstOrDefault(e => e.DiscountId.Equals(entity.DiscountId));
                if (original != null)
                {
                    _dataContext.Entry(original).CurrentValues.SetValues(entity);
                    _dataContext.SaveChanges();

                }

            }
        }

    }
}
