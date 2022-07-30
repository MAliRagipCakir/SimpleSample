using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class BaseAttribute : Entity<Guid>
    {
        public virtual string Name { get; set; }

        protected BaseAttribute()
        {

        }

        public BaseAttribute(string name)
        {
            Name = name;
        }
    }
}
