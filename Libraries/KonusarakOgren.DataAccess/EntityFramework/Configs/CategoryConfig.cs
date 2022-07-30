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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(CategoryConsts.MaxNameLength);

            builder.HasOne<Category>().WithMany(x => x.ChildCategories).HasForeignKey(x => x.ParentCategoryId).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.CategoryAttributes).WithOne().HasForeignKey(x => x.CategoryId).IsRequired();
        }
    }
}
