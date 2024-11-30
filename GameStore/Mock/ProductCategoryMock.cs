using GameStore.Models;

namespace GameStore.Mock
{
    public class ProductCategoryMock
    {
        public List<ProductCategory> ProductCategoryItems { get; set; }
        public ProductCategoryMock(List<ProductCategory> ProductCategoryItems)
        {
            this.ProductCategoryItems = ProductCategoryItems;
        }
    }
}
