using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> Search(string keyword);
    }
}
