using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Variant : Entity<Guid>
    {
        protected Variant()
        {

        }
        public Variant(string value, Guid categoryAttributeId)
        {
            Value = value;
            CategoryAttributeId = categoryAttributeId;
        }

        public virtual string Value { get; set; }

        public virtual Guid CategoryAttributeId { get; set; }
    }
}
