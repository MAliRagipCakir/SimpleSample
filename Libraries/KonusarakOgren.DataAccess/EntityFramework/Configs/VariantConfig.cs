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
    public class VariantConfig : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Value).IsRequired().HasMaxLength(VariantConsts.MaxValueLength);

            builder.HasOne<CategoryAttribute>().WithMany(x=>x.Variants).HasForeignKey(x => x.CategoryAttributeId).IsRequired();
        }
    }
}
