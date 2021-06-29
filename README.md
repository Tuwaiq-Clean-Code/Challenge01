# Challenge 01

### **Challenge Requirement**

#### find the code Smell in the function `UpdateQuality()` and Refactor the function.

---

### Code smell: **Long Method**


**Definition:** A method contains too many lines of code.


### Solution: Extract Method




the `UpdateQuality()` method looks like its doing three things, I started refactoring by extracting the big three if stamtents into methods

```C#
public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateItemQuality(item);

                UpdateSellIn(item);

                if (item.SellIn < 0)
                {
                    UpdateExpired(item);
                }
            }
        }
```

#

### Code smell: **Duplicate Code**


**Definition:** the code that increments/decrements the quality is duplicated many times


```C#
if (item.SellIn < 0)
    {
        UpdateExpired(item);
    }

....

if (Items[i].Quality < 50)
    {
        Items[i].Quality = Items[i].Quality + 1;
    }

....

if (item.Quality > 0)
    {
        item.Quality -= 1;
    }

```

### Solution: Extract Method



```C#
if (HasExpired(item))
    {
        UpdateExpired(item);
    }

...

void IncrementQuality(Item item)
{
    if (item.Quality < 50)
    {
        item.Quality += 1;
    }
}
...

void DecrementQuality(Item item)
{
    if (item.Quality > 0)
    {
        item.Quality -= 1;
    }
}
```

#

### Code smell: **Nested Conditionals**


**Definition:** a conditional block has another conditional block within it

```c#

private static void UpdateExpired(Item item)
{
    if (item.Name != "Aged Brie")
    {
        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
        {
            if (item.Quality > 0)
            {
                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
        else
        {
            item.Quality = item.Quality - item.Quality;
        }
    }
    else
    {
        IncrementQuality(item);
    }
}

```

### Solution: Exit early



```c#

private static void UpdateExpired(Item item)
{
    if (item.Name == "Aged Brie")
    {
        IncrementQuality(item);
    }
    else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
    {
        item.Quality = item.Quality - item.Quality;
    }
    else if (item.Name == "Sulfuras, Hand of Ragnaros") return;

    else
        DecrementQuality(item);
}
```

#

### Code smell: **Data Clumps**


**Definition:** different parts of the code share variables and methods


### Solution: Extract Class



some items in the GildedRoseInn have their own logic for updating Quality/SellIn, an `ItemCategory` class can be used as a base class to contain the default logic for updating Quality/SellIn/Expiry, special items can inherent the base class and override these methods.

- [ItemCategory](/csharp/ItemCategory/ItemCategory.cs)
    - [AgedBrie](/csharp/ItemCategory/AgedBrie.cs)
    - [BackstagePass](/csharp/ItemCategory/BackstagePass.cs)
    - [Sulfuras](/csharp/ItemCategory/Sulfuras.cs)
    - [Conjured](/csharp/ItemCategory/Conjured.cs)



---

**resources**:

- https://github.com/NotMyself/GildedRose
- http://iamnotmyself.com/2011/02/14/refactor-this-the-gilded-rose-kata/
