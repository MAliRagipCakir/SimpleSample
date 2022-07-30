using KonusarakOgren.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Abstract.Entities
{
    // Nesnelerin takibi için kullanılabilir
    public interface IAudited
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
