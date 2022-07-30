using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class OrderItem : Entity<Guid>
    {
        protected OrderItem()
        {

        }
        public OrderItem(int quantity, Guid productId, Guid orderId)
        {
            Quantity = quantity;
            ProductId = productId;
            OrderId = orderId;
        }

        public virtual int Quantity { get; set; }


        public virtual Guid ProductId { get; set; }
        public virtual Guid OrderId { get; set; }
    }
}
