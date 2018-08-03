using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
    public interface IAdminRepository : IRepository<Admin>
    {
        List<Admin> Search(string keyword);
    }
}
