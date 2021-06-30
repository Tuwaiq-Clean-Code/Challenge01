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

        protected bool ValidateNumber(string name)
        {
            return (name != "Aged Brie" && name != "Backstage passes to a TAFKAL80ETC concert"
              && name != "Sulfuras, Hand of Ragnaros");
        }

        protected bool isLessThanFifty(int number)
        {
            return number < 50;
        }

        protected bool isPositiveNumber(int number)
        {
            return number > 0;
        }
        
        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (ValidateNumber(item.Name) && isPositiveNumber(item.Quality))
                {
                    item.Quality -= 1;
                }
                else
                {
                    if (isLessThanFifty(item.Quality))
                    {
                        item.Quality += 1;

                        if (isLessThanFifty(item.Quality) && item.Name == "Backstage passes to a TAFKAL80ETC concert")
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
                        if (ValidateNumber(item.Name) && isPositiveNumber(item.Quality))
                            item.Quality -= 1;
                        else
                            item.Quality -= item.Quality;
                    }
                    else
                    {
                        if (isLessThanFifty(item.Quality))
                            item.Quality = item.Quality + 1;
                    }
                }
            }
        }

    }
}