using KonusarakOgren.Core.Abstract.Entities;
using KonusarakOgren.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class AppUser : IdentityUser, IAudited
    {
        // ..By, ..Date özellikleri context db.SaveChangesAsync metodu override edilerek tek noktadan kontrol edilebilir
        public string? CreatedBy { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }


        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
        public virtual List<Address> Addresses { get; set; } = new List<Address>();
        public virtual List<Order> Orders { get; set; } = new List<Order>();
        public virtual Guid? CartId { get; set; }
        public virtual Guid? StoreId { get; set; }
    }
}
