using csharp.Models;

namespace csharp.ItemUpdaters.ItemUpdaters
{
    public class SulfuraItemUpdater : ItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        protected override void UpdateSellIn(Item item) { }
        protected override int GetQualityValue(Item item) => 0;
        protected override void UpdateQuality(Item item, int qualityValue) { }
    }
}
