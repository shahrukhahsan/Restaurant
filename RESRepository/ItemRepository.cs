using RESEntity;
using RESInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESRepository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public List<Item> GetProductsByCategory(int categoryId)
        {
            return Context.Items.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
