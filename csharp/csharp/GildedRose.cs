using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        bool ItemHasQualityGreaterThanZero(Item item)
        {
            string[] namesToSkip = { "Aged Brie" , "Backstage passes to a TAFKAL80ETC concert" , "Sulfuras, Hand of Ragnaros" };
            return !namesToSkip.Contains(item.Name) && item.Quality>0;
        }

        bool CheckItemWithMaxQuality(Item item, string name, int maxQuality)
        {
            return (item.Name.Equals(name) && item.Quality < maxQuality);
        }

        public void UpdateQuality()
        {
            int maxQuality = 50;
            foreach (var item in Items)
            {
                if (ItemHasQualityGreaterThanZero(item))
                    --item.Quality;

                else if (item.Quality < maxQuality)
                {
                    ++item.Quality;
                    if  (CheckItemWithMaxQuality(item, "Backstage passes to a TAFKAL80ETC concert", maxQuality) && item.SellIn < 11)
                    {
                        ++ item.Quality;
                        if (item.SellIn < 6)
                            ++ item.Quality;
                    }
               }

                if (!item.Name.Equals("Sulfuras, Hand of Ragnaros"))
                    -- item.SellIn;

                if (item.SellIn < 0)
                {
                    if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                        item.Quality -= item.Quality;
                    
                    if (CheckItemWithMaxQuality(item, "Aged Brie", maxQuality))
                        ++ item.Quality;

                    if (ItemHasQualityGreaterThanZero(item))
                        -- item.Quality;
                }
            }
        }

    }
}
