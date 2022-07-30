using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Discount : AuditedEntity<Guid>
    {
        protected Discount()
        {

        }
        public Discount(int discountRate, bool ısActive, Guid productId)
        {
            DiscountRate = discountRate;
            IsActive = ısActive;
            ProductId = productId;
        }

        public virtual int DiscountRate { get; set; }
        public virtual bool IsActive { get; set; }

        public virtual Guid ProductId { get; set; }
    }
}
