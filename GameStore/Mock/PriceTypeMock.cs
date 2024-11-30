using GameStore.Models;

namespace GameStore.Mock
{
    public class PriceTypeMock
    {
        public List<PriceType> PriceTypeItems { get; set; }
        public PriceTypeMock(List<PriceType> PriceTypeItems)
        {
            this.PriceTypeItems = PriceTypeItems;
        }
    }
}
}
