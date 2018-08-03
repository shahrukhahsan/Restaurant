using RESEntity;
using RESInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public List<Category> Search(string keyword)
        {
            return null;
        }
    }
}
