using System.Collections.Generic;

namespace csharp
{


    public class GildedRose
    {
        public static bool validationName(string name)
        {
            return name != "Aged Brie" && name != "Backstage passes to a TAFKAL80ETC concert"
            && name != "Sulfuras, Hand of Ragnaros";
        }

        public static bool IsGreaterThanZero(int number)
        {
            return number > 0;
        }

        public static bool isUnderFifty(int number)
        {
            return number < 50;
        }
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (validationName(item.Name) && IsGreaterThanZero(item.Quality))
                {
                    item.Quality = item.Quality- 1;
                }
                else
                {
                    if (isUnderFifty(item.Quality))
                    {
                        item.Quality = item.Quality+ 1;

                        if (isUnderFifty(item.Quality) && item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                                item.Quality = item.Quality+ 1;
                        
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.SellIn = item.SellIn - 1;


                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (validationName(item.Name) && IsGreaterThanZero(item.Quality))
                            item.Quality = item.Quality- 1;
                        else
                            item.Quality = item.Quality -item.Quality;
                    }
                    else
                    {
                        if (isUnderFifty(item.Quality))
                            item.Quality = item.Quality + 1;
                    }
                }
            }
        }
      
    }
}
