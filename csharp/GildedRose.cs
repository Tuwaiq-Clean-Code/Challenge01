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
            for (var i = 0; i < Items.Count; i++)
            {
                if (isWrongName(Items[i].Name) && isQualityGraterThan0(Items[i].Quality))
                {
                    decreaseQualityByOne(Items[i].Quality);
                }
                else
                {
                    if (isQualityLessThan50(Items[i].Quality))
                    {
                        increaseQualityByOne(Items[i].Quality);

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert" && isSellInLessThan11(Items[i].SellIn)  && isQualityLessThan50(Items[i].Quality))
                        {

                            increaseQualityByOne(Items[i].Quality);

                            if (  isSellInLessThan6(Items[i].SellIn) && isQualityLessThan50(Items[i].Quality))
                            {
                                increaseQualityByOne(Items[i].Quality);
                                
                            }
                        }
                    }
                }

                if (isWrongName(Items[i].Name))
                {
                    decreaseSellInByOne(Items[i].SellIn);
                }

                if (isSellInLessThan0(Items[i].SellIn))
                {
                    if (isWrongName(Items[i].Name) &&  isQualityGraterThan0(Items[i].Quality))
                    {

                        decreaseQualityByOne(Items[i].Quality);


                    }
                        
                     else
                     {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                     }
                }
                else
                {
                        if (isQualityLessThan50(Items[i].Quality))
                        {
                           increaseQualityByOne(Items[i].Quality);
                        }
                }
            }
        }

        public static bool isWrongName(string Name)
        {
            return Name != "Aged Brie"
            && Name != "Backstage passes to a TAFKAL80ETC concert"
            && Name != "Sulfuras, Hand of Ragnaros";
        }

       public  int increaseQualityByOne(int qualityNumber)
       {
                return qualityNumber++;
       }

        public  int decreaseQualityByOne(int qualityNumber)
        {
            return qualityNumber--;
        }


        public  int decreaseSellInByOne(int SellInNumber)
        {
            return SellInNumber--;
        }
        public bool isQualityGraterThan0(int qualityNumber)
        {
            return qualityNumber > 0;
        }
        public bool isQualityLessThan50(int qualityNumber)
        {
            return qualityNumber < 50;
        }


        public bool isSellInLessThan0(int SellInNumber)
        {
            return SellInNumber < 0;
        }


        public bool isSellInLessThan11(int SellInNumber)
        {
            return SellInNumber < 11;
        }

        public bool isSellInLessThan6(int SellInNumber)
        {
            return SellInNumber < 6;
        }


    }
}

