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
    public class CategoryAttributeConfig : IEntityTypeConfiguration<CategoryAttribute>
    {
        public void Configure(EntityTypeBuilder<CategoryAttribute> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne<Category>().WithMany(x=>x.CategoryAttributes).HasForeignKey(x => x.CategoryId).IsRequired();
            builder.HasOne<BaseAttribute>().WithMany().HasForeignKey(x => x.AttributeId).IsRequired();
            builder.HasMany(x => x.Variants).WithOne().HasForeignKey(x => x.CategoryAttributeId).IsRequired();
        }
    }
}
