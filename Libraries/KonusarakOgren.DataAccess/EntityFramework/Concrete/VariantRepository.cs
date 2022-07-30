using KonusarakOgren.Core.Abstract.DataAccess;
using KonusarakOgren.DataAccess.Abstract;
using KonusarakOgren.DataAccess.EntityFramework.Context;
using KonusarakOgren.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.EntityFramework.Abstract
{
    public class VariantRepository : BaseRepository<Variant, Guid>, IVariantRepository
    {
        public VariantRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
