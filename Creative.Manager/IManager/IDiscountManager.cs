using Creative.Model.Model;
using Creative.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Manager.IManager
{
    public interface IDiscountManager
    {
        ResponseVM<DiscountVM> getDiscount(int id);
        ResponseVM<List<DiscountVM>> getAllDiscount();
        ResponseVM<DiscountVM> addDiscount(Discount discount);
        ResponseVM<bool> deleteDiscount(int id);

        ResponseVM<DiscountVM> updateDiscount(Discount discount);
    }
}
