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
                if (IsValidName(item.Name) && IsPositive(item.Quality))
                {
                    item.Quality -= 1;
                }
                else
                {
                    if (IsLessThanFifty(item.Quality))
                    {
                        item.Quality += 1;

                        if (IsLessThanFifty(item.Quality) && item.Name == "Backstage passes to a TAFKAL80ETC concert")
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
                        if (IsValidName(item.Name) && IsPositive(item.Quality))
                            item.Quality -= 1;
                        else
                            item.Quality -= item.Quality;
                    }
                    else
                    {
                        if (IsLessThanFifty(item.Quality))
                            item.Quality++;
                    }
                }
            }
        }
        public bool IsValidName(string name)
        {
            return name != "Aged Brie"
            && name != "Backstage passes to a TAFKAL80ETC concert"
            && name != "Sulfuras, Hand of Ragnaros";
        }

        public bool IsPositive(int num)
        {
            return num > 0;
        }

        public bool IsLessThanFifty(int num)
        {
            return num < 50;
        }
    }
}
