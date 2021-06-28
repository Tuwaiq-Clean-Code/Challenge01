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
                if (isValidName(item.Name) && isPositive(item.Quality))
                {
                    item.Quality -= 1;
                }
                else
                {
                    if (isBelowFifty(item.Quality))
                    {
                        item.Quality += 1;

                        if (isBelowFifty(item.Quality) && item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 6)
                                item.Quality += 2;
                            else if (item.SellIn < 11)
                                item.Quality += 1;
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.SellIn -= 1;

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (isValidName(item.Name) && isPositive(item.Quality))
                            item.Quality -= 1;
                        else
                            item.Quality -= item.Quality;
                    }
                    else
                    {
                        if (isBelowFifty(item.Quality))
                            item.Quality = item.Quality + 1;
                    }
                }
            }
        }
        protected bool isValidName(string name)
        {
            return name != "Aged Brie"
            && name != "Backstage passes to a TAFKAL80ETC concert"
            && name != "Sulfuras, Hand of Ragnaros";
        }

        protected bool isPositive(int num)
        {
            return num > 0;
        }

        protected bool isBelowFifty(int num)
        {
            return num < 50;
        }
    }
}
