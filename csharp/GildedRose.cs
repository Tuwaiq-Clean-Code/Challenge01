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
                if(isValidItemName(item.Name))
                {
                    if (hasPositiveQuality(item.Quality))
                    {
                        item.Quality -= 1;
                    }
                    
                }
                else
                {
                    if (hasQualityUnderFifty(item.Quality))
                    {
                        item.Quality += 1;

                        if(item.SellIn < 11 && hasQualityUnderFifty(item.Quality))
                        {
                            item.Quality += 1;
                        }
                        if (item.SellIn < 6 && hasQualityUnderFifty(item.Quality))
                        {
                            item.Quality += 1;
                        }
                    }
                }
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn -=  1;
                }

                if(item.SellIn < 0)
                {
                    if(item.Name != "Aged Brie")
                    {
                        if(item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if(hasPositiveQuality(item.Quality) && item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality -= 1;
                            }
                        } else
                        {
                            item.Quality -= item.Quality;
                        }
                    }
                } else if (hasQualityUnderFifty(item.Quality))
                {
                    item.Quality += 1;
                }
            }
        }

        public bool isValidItemName(string name)
        {
            if(name != "Aged Brie" 
                && name != "Backstage passes to a TAFKAL80ETC concert" 
                && name != "Sulfuras, Hand of Ragnaros")
            {
                return true;
            }
            return false;
        }

        public bool hasPositiveQuality(int quality)
        {
            return quality > 0;
        }

        public bool hasQualityUnderFifty(int quality)
        {
            return quality < 50;
        }

    }
}
