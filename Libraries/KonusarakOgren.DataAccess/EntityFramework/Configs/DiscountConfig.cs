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
    public class DiscountConfig : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(a => a.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.Now);
            builder.Property(a => a.CreatedBy).IsRequired(false);
            builder.Property(a => a.ModifiedDate).IsRequired(false);
            builder.Property(a => a.ModifiedDate).IsRequired(false);

            builder.HasOne<Product>().WithMany().HasForeignKey(x => x.ProductId).IsRequired();
        }
    }
}
