using RESEntity;
using RESInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public List<User> Search(string keyword)
        {
            return null;
        }
    }
}
