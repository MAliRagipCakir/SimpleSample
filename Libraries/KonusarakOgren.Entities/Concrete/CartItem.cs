using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class CartItem : Entity<Guid>
    {
        protected CartItem()
        {

        }
        public CartItem(int quantity, Guid productId, Guid cartId)
        {
            Quantity = quantity;
            ProductId = productId;
            CartId = cartId;
        }

        public virtual int Quantity { get; set; }

        public virtual Guid ProductId { get; set; }
        public virtual Guid CartId { get; set; }
    }
}
