namespace csharp
{
    class Conjured : ItemCategory
    {
        protected override void UpdateExpired(Item item)
        {
            DecrementQuality(item);
            DecrementQuality(item);
        }

        protected override void UpdateQuality(Item item)
        {
            DecrementQuality(item);
            DecrementQuality(item);
        }
    }
}