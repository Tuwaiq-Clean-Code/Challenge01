# Challenge 01


Code Smell:

``` 
if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
```
Definition: 
duplicate code

Solution:
Delete unnecessary if statement 
```
if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
```
<hr/>

Code Smell:
```  
if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert") 
```
Definition:
Long code 

Solution:
```
public static bool CheckName(name)
        {
            return (name != "Aged Brie" && name != "Backstage passes to a TAFKAL80ETC concert")
        }
```
```
 if (CheckName(Items[i].Name))
```

