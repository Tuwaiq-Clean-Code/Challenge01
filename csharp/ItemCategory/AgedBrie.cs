namespace csharp
{
    class AgedBrie : ItemCategory
    {
        protected override void UpdateExpired(Item item)
        {
            IncrementQuality(item);
        }

        protected override void UpdateQuality(Item item)
        {
            IncrementQuality(item);
        }
    }
}