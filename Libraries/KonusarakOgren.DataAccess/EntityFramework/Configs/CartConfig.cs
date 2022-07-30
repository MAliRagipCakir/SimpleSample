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
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalPrice).HasPrecision(18, 2);

            builder.HasMany(x => x.CartItems).WithOne().HasForeignKey(x => x.CartId).IsRequired();
            builder.HasOne(x=>x.User).WithOne().HasForeignKey<Cart>(x=>x.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
