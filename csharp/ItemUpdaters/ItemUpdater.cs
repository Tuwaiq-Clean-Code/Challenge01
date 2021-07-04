using csharp.Models;
using System;

namespace csharp.ItemUpdaters
{
    public abstract class ItemUpdater : IItemUpdater
    {
        public int MaxQualityValue { get; protected set; } = 50;
        public int MinQualityValue { get; protected set; } = 0;

        public abstract bool CanUpdate(Item item);
        protected abstract int GetQualityValue(Item item);

        public void Update(Item item)
        {
            if (item == null)
                throw new ArgumentNullException();

            UpdateSellIn(item);
            UpdateQuality(item, GetQualityValue(item));
        }

        protected virtual void UpdateSellIn(Item item)
        {
            --item.SellIn;
        }

        protected virtual void UpdateQuality(Item item, int qualityValue)
        {
            if (qualityValue > MaxQualityValue)
                item.Quality = MaxQualityValue;

            else if (qualityValue < MinQualityValue)
                item.Quality = MinQualityValue;

            else
                item.Quality = qualityValue;
        }
    }
}
