using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> Search(string keyword);
    }
}
