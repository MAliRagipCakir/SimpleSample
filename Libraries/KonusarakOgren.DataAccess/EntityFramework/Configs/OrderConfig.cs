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
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(a => a.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(a => a.CreatedBy).IsRequired(false);
            builder.Property(a => a.ModifiedDate).IsRequired(false);
            builder.Property(a => a.ModifiedDate).IsRequired(false);

            builder.Property(x => x.TotalPrice).HasPrecision(18, 2);

            builder.HasMany(x => x.OrderItems).WithOne().HasForeignKey(x => x.OrderId).IsRequired();
            builder.HasOne<AppUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
