using csharp.Models;

namespace csharp.ItemUpdaters
{
    public interface IItemUpdater
    {
        bool CanUpdate(Item item);
        void Update(Item item);
    }
}
