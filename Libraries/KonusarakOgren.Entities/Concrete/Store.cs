using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Store : AuditedEntity<Guid>
    {
        protected Store()
        {

        }
        public Store(string name, string userId)
        {
            Name = name;
            UserId = userId;
            Products = new List<Product>();
        }

        public virtual string Name { get; set; }

        
        public virtual string UserId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
