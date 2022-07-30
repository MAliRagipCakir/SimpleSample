using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Order : AuditedEntity<Guid>
    {
        protected Order()
        {

        }
        public Order(decimal totalPrice, string userId)
        {
            TotalPrice = totalPrice;
            UserId = userId;
            OrderItems = new List<OrderItem>();
        }

        public virtual decimal TotalPrice { get; set; }

        public virtual string UserId { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
    }
}
