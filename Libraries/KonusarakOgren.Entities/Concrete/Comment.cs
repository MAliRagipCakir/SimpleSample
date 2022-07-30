using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Concrete
{
    public class Comment : AuditedEntity<Guid>
    {
        protected Comment()
        {

        }
        public Comment(string title, string content, Guid productId, string userId)
        {
            Title = title;
            Content = content;
            ProductId = productId;
            UserId = userId;
        }

        public virtual string Title { get; set; }
        public virtual string Content { get; set; }

        public virtual Guid ProductId { get; set; }
        public virtual string UserId { get; set; }
    }
}
