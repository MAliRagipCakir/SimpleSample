using KonusarakOgren.Core.Constants;
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
    public class StoreConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(StoreConsts.MaxNameLength);

            builder.HasOne(x => x.User).WithOne().HasForeignKey<Store>(x => x.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Products).WithOne().HasForeignKey(x => x.StoreId).IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
