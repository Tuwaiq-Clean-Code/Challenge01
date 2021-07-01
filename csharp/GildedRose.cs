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
        public bool isStringAllowed(string text)
        {
            if(text != "Aged Brie" && text != "Backstage passes to a TAFKAL80ETC concert" 
                && text != "Sulfuras, Hand of Ragnaros") 
                return true;
            else 
                return false;
        }
        public bool isLessThanFifty(int number)
        {
            return number < 50;
        }
        public bool isPositiveNumber(int number)
        {
            return number > 0;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (isStringAllowed(item.Name) && isPositiveNumber(item.Quality))
                {
                    item.Quality--;
                }
                else if (isLessThanFifty(item.Quality))
                {
                    item.Quality++;
                    
                    if( (item.SellIn < 6 || item.SellIn < 11) && isLessThanFifty(item.Quality)
                        && item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        item.Quality++;
                }
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn--;
                }
                if (!isPositiveNumber(item.SellIn) && isPositiveNumber(item.Quality) )
                {
                    NegativeSellInAndPositiveQuality(item);
                }
            }
        }
        public void NegativeSellInAndPositiveQuality(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
                item.Quality -= item.Quality;

            else if (isStringAllowed(item.Name))
                item.Quality--;
            else if (isLessThanFifty(item.Quality))
                item.Quality++;
        }
    }
}
