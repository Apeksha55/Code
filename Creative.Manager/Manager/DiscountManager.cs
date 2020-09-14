using Creative.Manager.IManager;
using Creative.Model.Model;
using Creative.Model.ViewModel;
using Creative.Repository.IRepository;
using Creative.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative.Manager.Manager
{
   public  class DiscountManager: IDiscountManager
    {
        private readonly IDiscountRepository DiscountRepository;
        public CreativeEntities context = new CreativeEntities();
        public DiscountManager()
        {

            DiscountRepository = new DiscountRepository();

        }

        public ResponseVM<DiscountVM> getDiscount(int id)
        {
            var response = new ResponseVM<DiscountVM>();
            try
            {
                var Discount = DiscountRepository.GetById(id);
                response.Response = new DiscountVM(Discount);

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }

        public ResponseVM<List<DiscountVM>> getAllDiscount()
        {
            var response = new ResponseVM<List<DiscountVM>>();
            try
            {
                var Discounts = DiscountRepository.GetAll();
                response.Response = Discounts.Select(x => new DiscountVM(x)).ToList();

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
        public ResponseVM<DiscountVM> addDiscount(Discount Discount)
        {

            var response = new ResponseVM<DiscountVM>();
            try
            {
                var newDiscount = DiscountRepository.Insert(Discount);
                response.Response = new DiscountVM(newDiscount);

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }
        public ResponseVM<bool> deleteDiscount(int id)
        {
            var response = new ResponseVM<bool>();
            try
            {
                bool isSuccess = DiscountRepository.Delete(id);
                response.Response = isSuccess;

            }
            catch (Exception ex)
            {
                response.HasException = true;
                response.ErrorMsg = ex.Message;
            }
            return response;
        }

        public ResponseVM<DiscountVM> updateDiscount(Discount Discount)
        {

            var response = new ResponseVM<DiscountVM>();
            try
            {
                DiscountRepository.Update(Discount);
                response.Response = new DiscountVM(Discount);

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