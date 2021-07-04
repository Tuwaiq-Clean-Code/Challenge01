using csharp.Models;
using csharp.Repositories;
using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IItemRepository itemRepository = new ItemRepository();
            IList<Item> Items = itemRepository.GetAll();

            var app = new GildedRose(Items);
            PrintItems(Items, app);

            Console.ReadKey();
        }

        private static void PrintItems(IList<Item> Items, GildedRose app)
        {
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
