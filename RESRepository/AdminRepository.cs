using RESEntity;
using RESInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESRepository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public List<Admin> Search(string keyword)
        {
            return null;
        }
    }
}
