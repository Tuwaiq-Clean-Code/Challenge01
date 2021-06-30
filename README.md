# Challenge 01


Code Smell: Repeating( if else ) caused long method

Definition: hard understanding of long method that have many lines of repeted codes


Solution:

```
     public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecrementQuality(i);
                }
                else
                {              
                    UpdateQualityForItems(i);
                }
                
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    UpdateQualityForExpiredItems(i);
                }
            }
        }
