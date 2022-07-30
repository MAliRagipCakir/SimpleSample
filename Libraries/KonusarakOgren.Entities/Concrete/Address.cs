using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Address : Entity<Guid>
    {
        protected Address()
        {

        }

        public Address(string name, string city, string county, string userId)
        {
            Name = name;
            City = city;
            County = county;
            UserId = userId;
        }

        public virtual string Name { get; set; }
        public virtual string City { get; set; }
        public virtual string County { get; set; }

        public virtual string UserId { get; set; }
    }
}
