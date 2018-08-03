using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
<<<<<<< HEAD
    public interface IAdminRepository : IRepository<Admin>
=======
    public interface IAdminRepository
>>>>>>> 3aaa726202e2172a00bcf86d264624707c587d7f
    {
        List<Admin> Search(string keyword);
    }
}
