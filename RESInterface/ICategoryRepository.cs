using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
<<<<<<< HEAD
    public interface ICategoryRepository : IRepository<Category>
=======
    public interface ICategoryRepository
>>>>>>> 3aaa726202e2172a00bcf86d264624707c587d7f
    {
        List<Category> Search(string keyword);
    }
}
