using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Category : Entity<Guid>
    {
        protected Category()
        {

        }
        public Category(string name, Guid? parentCategoryId)
        {
            Name = name;
            ParentCategoryId = parentCategoryId;
            CategoryAttributes = new List<CategoryAttribute>();
            ChildCategories = new List<Category>();
        }

        public virtual string Name { get; set; }

        public virtual Guid? ParentCategoryId { get; set; }
        public virtual List<Category> ChildCategories { get; set; }
        public virtual List<CategoryAttribute> CategoryAttributes { get; set; }
    }
}
