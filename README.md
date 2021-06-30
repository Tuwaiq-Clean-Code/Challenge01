# Challenge 01

**GildedRose.cs** challenge.


## Code Smell:
There are diffparts of the code that I would describe as an example of diff types of code smells.
```
 if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                .
                .
                .
                if
                  if
                    if
                      action
                .
                .
                .
                 if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                .
                .
                .
```
## Definition: 
The code smells that I have recognized are:
-  complex conditional.
-  Nested if statements
-  Long Method.
-  duplicated code.
## Solution:
- Extract Method
- Form Template Method
- Decompose Conditional
- Combined if statements when possible.

```
public void UpdateQuality()
        {
            int maxQuality = 50;
            foreach (var item in Items)
            {
                if (ItemHasQualityGreaterThanZero(item))
                    --item.Quality;

                else if (item.Quality < maxQuality)
                {
                    ++item.Quality;
                    if  (CheckItemWithMaxQuality(item, "Backstage passes to a TAFKAL80ETC concert", maxQuality) && item.SellIn < 11)
                    {
                        ++ item.Quality;
                        if (item.SellIn < 6)
                            ++ item.Quality;
                    }
               }

                if (!item.Name.Equals("Sulfuras, Hand of Ragnaros"))
                    -- item.SellIn;

                if (item.SellIn < 0)
                {
                    if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                        item.Quality -= item.Quality;
                    
                    if (CheckItemWithMaxQuality(item, "Aged Brie", maxQuality))
                        ++ item.Quality;

                    if (ItemHasQualityGreaterThanZero(item))
                        -- item.Quality;
                }
            }
        }
```


**recourse**: 
- https://github.com/NotMyself/GildedRose
- http://iamnotmyself.com/2011/02/14/refactor-this-the-gilded-rose-kata/
