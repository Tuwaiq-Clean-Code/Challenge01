using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        //Method declartion

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        public static bool CheckNameNotEqual(string Name)
        {
            return Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert" && Name != "Sulfuras, Hand of Ragnaros";

        }
        public static bool CheckHigherThenZeroQuality(int Quality)
        {
            return Quality > 0;
        }
        public static bool CheckLessThanFiftyQuality(int Quality)
        {
            return Quality < 50;
        }
        public static int QualityPlusOne(int Quality)
        {
            return Quality + 1;
        }
        public static int QualityMinusOne(int Quality)
        {
            return Quality - 1;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {

                if (CheckNameNotEqual(item.Name) && CheckHigherThenZeroQuality(item.Quality))
                {item.Quality = QualityMinusOne(item.Quality);}

                else{
                
                    if (CheckLessThanFiftyQuality(item.Quality))
                    {
                        item.Quality = QualityPlusOne(item.Quality);

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11 && CheckLessThanFiftyQuality(item.Quality))
                            { item.Quality = QualityPlusOne(item.Quality); }
                        }

                        if (item.SellIn < 6 && CheckLessThanFiftyQuality(item.Quality))
                        { item.Quality = QualityPlusOne(item.Quality); }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                { item.SellIn = item.SellIn - 1; }

                if (item.SellIn < 0) {

                    if (item.Name != "Aged Brie")
                    {

                        if (CheckNameNotEqual(item.Name) && CheckHigherThenZeroQuality(item.Quality))
                        { item.Quality = QualityMinusOne(item.Quality); }

                        else { item.Quality = item.Quality - item.Quality;}
                    }

                    else
                    {
                        if (CheckLessThanFiftyQuality(item.Quality))
                        {item.Quality = QualityPlusOne(item.Quality); }
                    }
                }
            }
        }
    } }
    

