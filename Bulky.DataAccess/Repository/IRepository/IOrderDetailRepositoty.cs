﻿using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IOrderDetailRepositoty : IRepository<OrderDetails>
    {
        void Update(OrderDetails obj);
        
    }
}
