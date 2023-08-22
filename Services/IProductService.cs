using ProductsAPI_DbFirst_.Models;

namespace ProductsAPI_DbFirst_.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public void PostProductDetails(Product product);
        public void PutProductDetails(int ProductId, Product product);
        public void DeleteProductDetails(int ProductId);
        public Product GetProductDetails(int ProductId);
    }
}
