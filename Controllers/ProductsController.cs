using Microsoft.AspNetCore.Mvc;
using ProductsAPI_DbFirst_.Models;
using ProductsAPI_DbFirst_.Services;

namespace ProductsAPI_DbFirst_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProductsNames()
        {

            return Ok(_productService.GetProducts());
        }
        [HttpGet]
        // [Route {{id}}]
        public IActionResult GetProductsNames(int Id)
        {

            return Ok(_productService.GetProductDetails(Id));
        }

        [HttpPost]
        [Route("PostProducts")]

        public IActionResult PostProduct(Product product)
        {
            _productService.PostProductDetails(product);
            return NoContent();
        }
        [HttpPut]
        public IActionResult PutProduct(int ProductId, Product updatedProduct)
        {
            _productService.PutProductDetails(ProductId, updatedProduct);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int Id)
        {
            _productService.DeleteProductDetails(Id);
            return NoContent();
        }

    }
}
