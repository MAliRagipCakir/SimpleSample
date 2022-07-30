using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Product : AuditedEntity<Guid>
    {
        protected Product()
        {

        }
        public Product(string name, string description, decimal price, string parameters, int stock, Guid storeId, Guid categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            Parameters = parameters;
            Stock = stock;
            StoreId = storeId;
            CategoryId = categoryId;
            Comments = new List<Comment>();
            Discounts = new List<Discount>();
        }
        // Propertylerin set metotları private yapılarak encapsulation sağlanabilir ve SetName, SetPrice gibi metotlarla kontrollü şekilde yapılabilir.
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Parameters { get; set; }
        public virtual int Stock { get; set; }


        public virtual Guid StoreId { get; set; }
        public virtual Guid CategoryId { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Discount> Discounts { get; set; }
    }
}
