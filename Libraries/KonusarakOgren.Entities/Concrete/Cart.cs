using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Cart : Entity<Guid>
    {
        protected Cart()
        {

        }

        public Cart(decimal totalPrice, string userId)
        {
            TotalPrice = totalPrice;
            UserId = userId;
            CartItems = new List<CartItem>();
        }

        public virtual decimal TotalPrice { get; set; }

        public virtual string UserId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
