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
                bool isItemAged = Items[i].Name == "Aged Brie";
                bool isItemSulfuras = Items[i].Name == "Sulfuras, Hand of Ragnaros";
                bool isItemBackstagePass = Items[i].Name == "Backstage passes to a TAFKAL80ETC concert";
                bool isItemNormal = Items[i].Name == "+5 Dexterity Vest" || Items[i].Name == "Elixir of the Mongoose";
                bool isItemConjured = Items[i].Name == "Conjured Mana Cake";
                bool isSellInLessThan11 = Items[i].SellIn < 11;
                bool isSellInLessThan6 = Items[i].SellIn < 6;


                if (isItemSulfuras)
                {
                    continue;
                }

                Items[i].SellIn = Items[i].SellIn - 1;

                if (isItemBackstagePass)
                {
                    if(Items[i].SellIn <= 0)
                    {
                        Items[i].Quality = 0;
                    }
                    else if (isSellInLessThan6)
                    {
                        Items[i].Quality = Items[i].Quality + 2;
                    }
                    else if (isSellInLessThan11)
                    {
                        Items[i].Quality = Items[i].Quality + 3;
                    }
                    else ++ Items[i].Quality;
                }

                else if (isItemAged)
                {
                    
                    if (Items[i].Quality < 50)
                    {
                        ++Items[i].Quality;
                        if(Items[i].SellIn < 0)
                            ++Items[i].Quality;
                    }
                }

                else if (isItemConjured)
                {
                    if (Items[i].Quality > 0)
                        Items[i].Quality -= 2;
                }

                else if (isItemNormal )
                {
                    if(Items[i].Quality > 0)
                    {
                        --Items[i].Quality;
                    }
                    
                }
                else throw new System.NotSupportedException($"{Items[i].Name} is Unknown type");

            }
        }
    }
}
