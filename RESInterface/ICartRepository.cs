using System;
using System.Collections.Generic;
using RESEntity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
    public interface ICartRepository : IRepository<Cart>
    {
        List<Cart> Search(string keyword);
    }
}
