using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creative.Model;

using Creative.Repository;


using Creative.Model.Model;
using Creative.Repository.IRepository;
using Creative.Manager.IManager;

using Creative.Model.ViewModel;

namespace Creative.Manager
{

    public class ProductManager:IProductManager
    {
        private readonly IProductRepository ProductRepository;
        public CreativeEntities context = new CreativeEntities();
       
        public ProductManager ()
        {

            ProductRepository=new ProductRepository();
    
        }
        
       public ResponseVM<ProductVM> getProduct(int id)
        {
            var response = new ResponseVM<ProductVM>();
            try
            {
                var Product = ProductRepository.GetById(id);
                response.Response = new ProductVM(Product);

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }

        public ResponseVM<List<ProductVM>> getAllProduct()
        {
            var response = new ResponseVM<List<ProductVM>>();
            try
            {
                var Products = ProductRepository.GetAll();
                response.Response = Products.Select(x => new ProductVM(x)).ToList();

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
        public ResponseVM<ProductVM> addProduct(Product product) {

            var response = new ResponseVM<ProductVM>();
            try
            {
                var newProduct = ProductRepository.Insert(product);
                response.Response = new ProductVM(newProduct);

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
        public ResponseVM<bool> deleteProduct(int id)
        {
            var response = new ResponseVM<bool>();
            try
            {
                bool isSuccess= ProductRepository.Delete(id);
                response.Response = isSuccess;

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }

        public ResponseVM<ProductVM> updateProduct(Product Product) {

            var response = new ResponseVM<ProductVM>();
            try
            {
               ProductRepository.Update(Product);
               response.Response = new ProductVM(Product);

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
    }

}
