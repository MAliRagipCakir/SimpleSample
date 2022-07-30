using KonusarakOgren.Core.Abstract.DataAccess;
using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.DataAccess.EntityFramework.Context;
using KonusarakOgren.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.EntityFramework.Abstract
{
    public class OrderRepository : BaseRepository<Order, Guid>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
