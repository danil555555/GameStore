using GameStore.Models;

namespace GameStore.Mock
{
    public class ProductMock
    {
        public List<Product> ProductItems { get; set; }
        public ProductMock(List<Product> ProductItems) 
        {
            this.ProductItems = ProductItems;
        }
    }
}
