using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateItemQuality(item);

                UpdateSellIn(item);

                if (HasExpired(item))
                {
                    UpdateExpired(item);
                }
            }
        }
        
        private static void UpdateExpired(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                IncrementQuality(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                item.Quality = item.Quality - item.Quality;
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros") return;
            
            else
                DecrementQuality(item);
        }
        
        private static void UpdateSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        private static void UpdateItemQuality(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                IncrementQuality(item);
            }

            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
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
            
            else
            {
                if (item.Quality <= 0) return;
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }

        private static bool HasExpired(Item item)
        {
            return item.SellIn < 0;
        }

        private static void IncrementQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private static void DecrementQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}
