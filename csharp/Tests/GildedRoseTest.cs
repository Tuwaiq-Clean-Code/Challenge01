using csharp.Models;
using csharp.Repositories;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IItemRepository itemRepository = new ItemRepository();

            IList<Item> items = itemRepository.GetAll();

            string itemName = items[0].Name;
            
            GildedRose app = new GildedRose(items);

            app.UpdateQuality();
            
            Assert.AreEqual(itemName, items[0].Name);
        }
    }
}
