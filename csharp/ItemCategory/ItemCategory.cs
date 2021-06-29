namespace csharp
{
    class ItemCategory
    {
        private const int MaxQuality = 50;

        private bool HasExpired(Item item)
        {
            return item.SellIn < 0;
        }
        
        protected virtual void UpdateQuality(Item item)
        {
            DecrementQuality(item);
        }

        protected virtual void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        protected virtual void UpdateExpired(Item item)
        {
            DecrementQuality(item);
        }

        protected static void IncrementQuality(Item item)
        {
            if (item.Quality < MaxQuality)
            {
                item.Quality += 1;
            }
        }

        protected static void DecrementQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }
        
        public void UpdateItem(Item item)
        {
            this.UpdateQuality(item);

            this.UpdateSellIn(item);

            if (HasExpired(item))
            {
                this.UpdateExpired(item);
            }
        }
    }
}