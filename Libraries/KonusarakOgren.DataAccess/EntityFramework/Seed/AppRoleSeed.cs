using KonusarakOgren.Core.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.EntityFramework.Seed
{
    public class AppRoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Name = AppRoles.SysAdmin.ToString(),
                NormalizedName = AppRoles.SysAdmin.ToString().ToUpper()
            });
            builder.HasData(new IdentityRole
            {
                Name = AppRoles.Admin.ToString(),
                NormalizedName = AppRoles.Admin.ToString().ToUpper()
            });
            builder.HasData(new IdentityRole
            {
                Name = AppRoles.User.ToString(),
                NormalizedName = AppRoles.User.ToString().ToUpper()
            });
        }
    }
}
