using KonusarakOgren.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.EntityFramework.Configs
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(a => a.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(a => a.CreatedBy).IsRequired(false);
            builder.Property(a => a.ModifiedDate).IsRequired(false);
            builder.Property(a => a.ModifiedDate).IsRequired(false);

            builder.HasOne<Cart>().WithOne(x => x.User).HasForeignKey<Cart>(x => x.UserId).IsRequired(true);
            builder.HasOne<Store>().WithOne(x => x.User).HasForeignKey<Store>(x => x.UserId).IsRequired(true);
            builder.HasMany(x=>x.Comments).WithOne().HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x=>x.Addresses).WithOne().HasForeignKey(x=>x.UserId);
            builder.HasMany(x=>x.Orders).WithOne().HasForeignKey(x=>x.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
