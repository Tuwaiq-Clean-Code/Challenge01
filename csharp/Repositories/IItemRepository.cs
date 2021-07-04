using csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Repositories
{
    public interface IItemRepository
    {
        List<Item> GetAll();
    }
}
