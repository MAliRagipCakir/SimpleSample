using KonusarakOgren.Core.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities.Abstract
{
    public class Entity<T> : IEntity<T>, IBaseEntity
    {
        public T Id { get ; set; }
    }
}
