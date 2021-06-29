using System.Collections.Generic;
using System.Data;

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
                ItemCategory category = Categorize(item);
                UpdateItem(item, category);
            }
        }
        
        public void UpdateItem(Item item, ItemCategory category)
        {
            category.UpdateItemQuality(item);

            category.UpdateSellIn(item);

            if (HasExpired(item))
            {
                category.UpdateExpired(item);
            }
        }

        private ItemCategory Categorize(Item item)
        {
            return null;
        }

        private static bool HasExpired(Item item)
        {
            return item.SellIn < 0;
        }
    }

    public class ItemCategory
    {
        public void IncrementQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        public void DecrementQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }

        public void UpdateExpired(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                this.IncrementQuality(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                item.Quality = item.Quality - item.Quality;
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros") return;
            
            else
                this.DecrementQuality(item);
        }

        public void UpdateSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        public void UpdateItemQuality(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                this.IncrementQuality(item);
            }

            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                this.IncrementQuality(item);
                if (item.SellIn < 11)
                {
                    this.IncrementQuality(item);
                }

                if (item.SellIn < 6)
                {
                    this.IncrementQuality(item);
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
    }
}
