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
    public class BaseAttributeConfig : IEntityTypeConfiguration<BaseAttribute>
    {
        public void Configure(EntityTypeBuilder<BaseAttribute> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(BaseAttributeConsts.MaxNameLength);

            builder.HasMany<CategoryAttribute>().WithOne().HasForeignKey(x => x.AttributeId).IsRequired();
        }
    }
}
