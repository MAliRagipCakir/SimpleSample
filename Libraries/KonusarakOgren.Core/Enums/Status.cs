using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Enums
{
    public enum Status
    {
        [Display(Name = "Active")]
        Active = 1,
        [Display(Name = "Modified")]
        Modified,
        [Display(Name = "Passive")]
        Passive,
    }
}
