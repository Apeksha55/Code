using Creative.Manager;
using Creative.Manager.IManager;
using Creative.Model.Model;
using System.Web.Http;

namespace Creative.API.Controllers
{
    public class ProductController : ApiController
    {

        private readonly IProductManager _ProductManager;
        public ProductController()
        {
            _ProductManager = new ProductManager();

        }
        

        [HttpGet]
        //[Authorize]
        [Route("api/Products/getAllProducts")]
        public IHttpActionResult getAllProducts()
        {
            var response = _ProductManager.getAllProduct();
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }


        //[Authorize]
        [Route("api/Products/getProduct")]
        public IHttpActionResult getProduct(int id)
        {
            var response = _ProductManager.getProduct(id);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }

        [HttpPost]
        
        //[Authorize(Products = "Admin")]
        [Route("api/Products/addProduct")]
        public IHttpActionResult addProduct([FromBody] Product Product)
        {
            var response = _ProductManager.addProduct(Product);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }

        [HttpDelete]
        //[Authorize(Products = "Admin")]
        [Route("api/Products/deleteProduct")]
        public IHttpActionResult deleteProduct(int id)
        {
            var response = _ProductManager.deleteProduct(id);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }

        [HttpPut]
        //[Authorize(Products = "Admin")]
        [Route("api/Products/updateProduct")]
        public IHttpActionResult updateProduct([FromBody] Product Product)
        {
            var response = _ProductManager.updateProduct(Product);
            if (response.HasException)
            {
                return InternalServerError();
            }

            return Json(response.Response);
        }
    }
}
