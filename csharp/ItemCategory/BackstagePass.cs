namespace csharp
{
    class BackstagePass : ItemCategory
    {
        
        protected override void UpdateExpired(Item item)
        {
            item.Quality -= item.Quality;
        }

        protected override void UpdateQuality(Item item)
        {
            IncrementQuality(item);
            if (item.SellIn < 11)
            {
                IncrementQuality(item);
            }

            if (item.SellIn < 6)
            {
                IncrementQuality(item);
            }
        }

        protected override void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }
    }
}