using System.Collections.Generic;
namespace csharp
{
    public class GildedRose
    {
        bool IsValidName(string name)
        {
            return (!name.Equals("Aged Brie") &&
                    !name.Equals("Backstage passes to a TAFKAL80ETC concert") &&
                    !name.Equals("Sulfuras, Hand of Ragnaros"));
        }
        bool IsMoreThanZero(int num)
        {
            return num > 0;
        }
        bool isLessThanFifty(int num)
        {
            return num < 50;
        }
        IList<Item> Items;
        GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (IsValidName(item.Name) && IsMoreThanZero(item.Quality))
                {
                    item.Quality -= 1;
                }
                else
                {
                    if (isLessThanFifty(item.Quality))
                    {
                        item.Quality = item.Quality + 1;
                        if (isLessThanFifty(item.Quality) && item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                                item.Quality += item.Quality;
                        }
                    }
                }
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.SellIn =- 1;
                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (IsValidName(item.Name) && IsMoreThanZero(item.Quality))
                            item.Quality -= 1;
                        else
                            item.Quality -= item.Quality;
                    }
                    else
                    {
                        if (isLessThanFifty(item.Quality))
                            item.Quality += 1;
                    }
                }
            }
        }
    }
}