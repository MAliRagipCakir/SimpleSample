using KonusarakOgren.Core.Abstract.DataAccess;
using KonusarakOgren.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.Abstract
{
    public interface ICommentRepository : IRepository<Comment, Guid>
    {
    }
}
