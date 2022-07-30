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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(ProductConsts.MaxNameLength);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(ProductConsts.MaxDescriptionLength);
            builder.Property(x => x.Price).HasPrecision(18, 2);

            builder.HasOne<Store>().WithMany().HasForeignKey(x => x.StoreId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Category>().WithMany().HasForeignKey(x => x.CategoryId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Comments).WithOne().HasForeignKey(x => x.ProductId).IsRequired();
            builder.HasMany(x => x.Discounts).WithOne().HasForeignKey(x => x.ProductId).IsRequired();
        }
    }
}
