using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class CategoryAttribute : Entity<Guid>
    {
        protected CategoryAttribute()
        {

        }
        public CategoryAttribute(bool ısRequired, Guid categoryId, Guid attributeId)
        {
            IsRequired = ısRequired;
            CategoryId = categoryId;
            AttributeId = attributeId;
            Variants = new List<Variant>();
        }

        public virtual bool IsRequired { get; set; }

        public virtual Guid CategoryId { get; set; }
        public virtual Guid AttributeId { get; set; }
        public virtual List<Variant> Variants { get; set; }
    }
}
