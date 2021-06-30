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

        protected bool isValidName(string name)
        {
            if (name != "Aged Brie"
            && name != "Backstage passes to a TAFKAL80ETC concert"
            && name != "Sulfuras, Hand of Ragnaros") return true;
            return false;
        }

        protected bool isQualityPositive(int num)
        {
            return num > 0;
        }

        protected bool isQualityBelowFifty(int num)
        {
            return num < 50;
        }

        public void UpdateQuality()
        {
            foreach (var t in Items)
            {
                var _isQualityBelowFifty = isQualityBelowFifty(t.Quality);
                var _isValidName = isValidName(t.Name);
                var _isQualityPositive = isQualityPositive(t.Quality);
                
                if (_isValidName && _isQualityPositive)
                {
                    t.Quality = t.Quality - 1;
                }
                else if (_isQualityBelowFifty)
                {
                    t.Quality += 1;
                    if (t.Name == "Backstage passes to a TAFKAL80ETC concert" && (t.SellIn < 11 || t.SellIn < 6))
                        t.Quality += 1;
                }
                if (t.Name != "Sulfuras, Hand of Ragnaros")
                    t.SellIn -= 1;
                if (t.SellIn >= 0 || !_isQualityPositive) continue;

                if (t.Name != "Aged Brie")
                {
                    if (_isValidName)
                        t.Quality -= 1;
                    else
                        t.Quality = 0;
                }
                else if (_isQualityBelowFifty)
                        t.Quality += 1;
            }
        }
    }
}