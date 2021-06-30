# Challenge 01


Code Smell:  Long method (UpdateQuality()).

Definition: method is long and can be divided into smaller methods .

Solution: taking out the parts of the method that can be brought out independently as IncreaseQuality() and DecreaseQuality(), then calling them from Update whenever needed.  

<hr/>

Code Smell:  unnecessary nested if statements 

Definition: the method UpdateQuality() contains nested if statements.

For example the following code:
<pre><code>
if (item.SellIn < 11)
{
    if (item.Quality < 50)
    {
        item.Quality = item.Quality + 1;
    }
}

if (item.SellIn < 6)
{
    if (item.Quality < 50)
    {
        item.Quality = item.Quality + 1;
    }
}
</code></pre>

Solution: The above example Can be simplfied to:
<pre><code>
if (item.SellIn < 11 && item.Quality < 50)
{
    item.Quality = item.Quality + 1;
}

if (item.SellIn < 6 && item.Quality < 50)
{
        item.Quality = item.Quality + 1;
}
</code></pre>
