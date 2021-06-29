using System.Collections.Generic;
namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)=>this.Items = Items;

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (isValidName(item.Name) && IsGreaterThanZero(item.Quality))
                {
                    item.Quality--;
                }
                else
                {
                    if (isLessThanFifty(item.Quality))
                    {
                        item.Quality++;
                        if (isLessThanFifty(item.Quality) && item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11)
                                item.Quality++;
                        }
                    }
                }
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.SellIn--;
                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (isValidName(item.Name) && IsGreaterThanZero(item.Quality))
                            item.Quality--;
                        else
                            item.Quality -= item.Quality;
                    }
                    else
                    {
                        if (isLessThanFifty(item.Quality))
                            item.Quality++;
                    }
                }
            }
        }

        private bool isValidName(string name)
        {
            return name != "Aged Brie" && name != "Backstage passes to a TAFKAL80ETC concert"
            && name != "Sulfuras, Hand of Ragnaros";
        }
        private bool IsGreaterThanZero(int number)
        {
            return number > 0;
        }
        private bool isLessThanFifty(int number)
        {
            return number < 50;
        }


        
    }
}