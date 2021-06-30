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

        public void Update()
        {
            foreach (var item in Items)
            {
                UpdateSellIn(item);
                UpdateQuality(item);
            }
        }

        public void UpdateSellIn(Item item)
        {
            if (IsLegendaryItem(item))
                return;

            item.SellIn--;
        }
        
        public void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                if (IsIncreasedByAge(item))
                {
                    if (item.Quality >= 50)
                        return;
                    
                    item.Quality++;
                    return;
                }
                
                if (item.Name != "Backstage passes to a TAFKAL80ETC concert" &&
                    item.Quality > 0 &&
                    !IsLegendaryItem(item))
                {
                    item.Quality--;
                    return;
                }

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    item.Quality = 0;
                
                return;
            }
            
            if (item.Name != "Aged Brie" &&
                item.Name != "Backstage passes to a TAFKAL80ETC concert" &&
                item.Quality > 0 &&
                !IsLegendaryItem(item))
            {
                item.Quality--;
            }
            else if (item.Quality < 50)
            {
                item.Quality++;

                if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    return;
                    
                if (item.SellIn < 11 && item.Quality < 50)
                {
                    item.Quality++;
                }

                if (item.SellIn < 6 && item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }
        
        private bool IsLegendaryItem(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        private bool IsIncreasedByAge(Item item)
        {
            return item.Name == "Aged Brie";
        }
    }
}
