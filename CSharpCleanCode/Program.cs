using CSharpCleanCode.GildedRoseINN;
using CSharpCleanCode.GildedRoseINN.Items;
using System;
using System.Collections.Generic;

namespace CSharpCleanCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RunOriginExample();
            RunRefactoredCode();
        }

        public static void RunRefactoredCode()
        {
            Console.WriteLine("OMGHAI!");

            IList<BaseItem> Items = GetData();

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("\n-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++) System.Console.WriteLine(Items[j]);
                app.RefactoredUpdateQuality();
            }
        }
	    
	private List<BaseItem> GetData()
	{
		return new List<BaseItem> {
                new NormalItem("+5 Dexterity Vest", 10, 20),
                new AgedBrieItem("Aged Brie", 2, 0),
                new NormalItem("Elixir of the Mongoose", 5, 7),
                new SulfuraItem("Sulfuras, Hand of Ragnaros", 0, 80),
                new SulfuraItem("Sulfuras, Hand of Ragnaros", -1, 80),
                new BackstagePassesItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new BackstagePassesItem("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new BackstagePassesItem("Backstage passes to a TAFKAL80ETC concert", 5, 49),
				new ConjuredItem("Conjured Mana Cake", 3, 6)
            };
	}


    }
}
