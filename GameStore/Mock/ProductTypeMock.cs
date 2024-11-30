using GameStore.Models;

namespace GameStore.Mock
{
    public class ProductTypeMock
    {
        public List<ProductType> ProductTypeItems { get; set; }
        public ProductTypeMock(List<ProductType> ProductTypeItems)
        {
            this.ProductTypeItems = ProductTypeItems;
        }
    }
}
