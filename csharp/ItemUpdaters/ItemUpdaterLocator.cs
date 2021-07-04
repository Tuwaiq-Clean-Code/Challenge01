using csharp.Models;
using System;
using System.Collections.Generic;

namespace csharp.ItemUpdaters
{
    public class ItemUpdaterLocator
    {
        public List<IItemUpdater> ItemUpdaters { get; protected set; }

        public ItemUpdaterLocator(List<IItemUpdater> itemUpdaters)
        {
            this.ItemUpdaters = itemUpdaters;
        }

        public IItemUpdater Locate(Item item)
        {
            foreach (var itemUpdater in ItemUpdaters)
                if (itemUpdater.CanUpdate(item)) return itemUpdater;

            throw new NotSupportedException();
        }   
    }
}
