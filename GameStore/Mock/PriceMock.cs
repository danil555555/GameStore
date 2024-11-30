using GameStore.Models;

namespace GameStore.Mock
{
    public class PriceMock
    {
        public List<Price> PriceItems { get; set; }
        public PriceMock(List<Price> PriceItems)
        {
            this.PriceItems = PriceItems;
        }
    }
}
