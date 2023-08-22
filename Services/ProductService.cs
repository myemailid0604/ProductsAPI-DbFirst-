using ProductsAPI_DbFirst_.Data;
using ProductsAPI_DbFirst_.Models;

namespace ProductsAPI_DbFirst_.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _productDbContext;
        public ProductService(ProductDbContext productDbContext)
        {
            this._productDbContext = productDbContext;
                
        }

        

        public List<Product> GetProducts()
        {
            return _productDbContext.Products.ToList();
        }

        public void PostProductDetails(Product product)
        {
            _productDbContext.Products.AddAsync(new Product()
            {
                ProductId=0,
                ProductName=product.ProductName,
                ProductDescription=product.ProductDescription,
                ProductPrice=product.ProductPrice
                
            });
            _productDbContext.SaveChangesAsync();
        }

        public void PutProductDetails(int ProductId,Product updatedProduct)
        {
            var product = _productDbContext.Products.Where(x => x.ProductId == ProductId).FirstOrDefault();
            if (product != null)
            {
                product.ProductName = string.IsNullOrEmpty(updatedProduct.ProductName) ?  product.ProductName : updatedProduct.ProductName;
                product.ProductDescription = string.IsNullOrEmpty(updatedProduct.ProductDescription) ? product.ProductDescription: updatedProduct.ProductDescription;
                product.ProductPrice = updatedProduct.ProductPrice ?? product.ProductPrice;
                _productDbContext.SaveChangesAsync();
            }
        }
        public void DeleteProductDetails(int ProductId)
        {
            var product = _productDbContext.Products.Where(x => x.ProductId == ProductId).FirstOrDefault();
            _productDbContext.Products.Remove(product);
            _productDbContext.SaveChanges();
        }

        public Product GetProductDetails(int ProductId)
        {
            Product product = _productDbContext.Products.Where(x => x.ProductId == ProductId).FirstOrDefault();
            return product;

        }
    }
}
