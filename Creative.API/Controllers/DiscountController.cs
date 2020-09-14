using Creative.Manager;
using Creative.Manager.IManager;
using Creative.Manager.Manager;
using Creative.Model.Model;
using System.Web.Http;

namespace Creative.API.Controllers
{
    public class DiscountController : ApiController
    {

        private readonly IDiscountManager _DiscountManager;
        public DiscountController()
        {
            _DiscountManager = new DiscountManager();

        }


        [Route("api/Discounts/getAllDiscounts")]
        [HttpGet]
        public IHttpActionResult getAllDiscounts()
        {
            var response = _DiscountManager.getAllDiscount();
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }


        //[Authorize]
        [Route("api/Discounts/getDiscount")]
        public IHttpActionResult getDiscount(int id)
        {
            var response = _DiscountManager.getDiscount(id);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }

        [HttpPost]
        
        //[Authorize(Discounts = "Admin")]
        [Route("api/Discounts/addDiscount")]
        public IHttpActionResult addDiscount([FromBody] Discount Discount)
        {
            var response = _DiscountManager.addDiscount(Discount);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }

        [HttpDelete]
        //[Authorize(Discounts = "Admin")]
        [Route("api/Discounts/deleteDiscount")]
        public IHttpActionResult deleteDiscount(int id)
        {
            var response = _DiscountManager.deleteDiscount(id);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }

        [HttpPut]
        //[Authorize(Discounts = "Admin")]
        [Route("api/Discounts/updateDiscount")]
        public IHttpActionResult updateDiscount([FromBody] Discount Discount)
        {
            var response = _DiscountManager.updateDiscount(Discount);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }
    }
}
