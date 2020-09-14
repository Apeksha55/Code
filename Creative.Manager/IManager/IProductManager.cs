
using Creative.Model;
using Creative.Model.Model;
using Creative.Model.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Creative.Manager.IManager
{
    public interface IProductManager
    {
        ResponseVM<ProductVM> getProduct(int id);
        ResponseVM<List<ProductVM>> getAllProduct();
        ResponseVM<ProductVM> addProduct(Product Product);
        ResponseVM<bool> deleteProduct(int id);

        ResponseVM<ProductVM> updateProduct(Product Product);
    }
}
