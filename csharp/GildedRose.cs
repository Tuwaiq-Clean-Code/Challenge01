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
                category.UpdateItem(item);
            }
        }

        private ItemCategory Categorize(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new Sulfuras();
            }

            if (item.Name == "Aged Brie")
            {
                return new AgedBrie();
            }

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackstagePass();
            }

            if (item.Name == "Conjured Mana Cake")
            {
                return new Conjured();
            }

            return new ItemCategory();
        }
    }

    class Sulfuras : ItemCategory
    {
        protected override void UpdateExpired(Item item)
        {
        }

        protected override void UpdateItemQuality(Item item)
        {
        }

        protected override void UpdateSellIn(Item item)
        {
        }
    }

    class AgedBrie : ItemCategory
    {
        protected override void UpdateExpired(Item item)
        {
            IncrementQuality(item);
        }

        protected override void UpdateItemQuality(Item item)
        {
            IncrementQuality(item);
        }
    }

    class BackstagePass : ItemCategory
    {
        protected override void UpdateExpired(Item item)
        {
            item.Quality -= item.Quality;
        }

        protected override void UpdateItemQuality(Item item)
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


    class Conjured : ItemCategory
    {
        protected override void UpdateExpired(Item item)
        {
            DecrementQuality(item);
            DecrementQuality(item);
        }

        protected override void UpdateItemQuality(Item item)
        {
            DecrementQuality(item);
            DecrementQuality(item);
        }
    }


    class ItemCategory
    {
        private bool HasExpired(Item item)
        {
            return item.SellIn < 0;
        }

        protected static void IncrementQuality(Item item)
        {
            if (item.Quality < 50)
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

        protected virtual void UpdateExpired(Item item)
        {
            DecrementQuality(item);
        }

        protected virtual void UpdateItemQuality(Item item)
        {
            DecrementQuality(item);
        }

        protected virtual void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        public void UpdateItem(Item item)
        {
            this.UpdateItemQuality(item);

            this.UpdateSellIn(item);

            if (HasExpired(item))
            {
                this.UpdateExpired(item);
            }
        }
    }
}