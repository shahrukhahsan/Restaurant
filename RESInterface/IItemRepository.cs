﻿using System;
using RESEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESInterface
{
    public interface IItemRepository : IRepository<Item>
    {
        List<Item> GetItemsByCategory(int categoryId);
    }
}
