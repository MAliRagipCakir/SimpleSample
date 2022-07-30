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
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(AddressConsts.MaxNameLength);
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.County).IsRequired();

            builder.HasOne<AppUser>().WithMany(x => x.Addresses).HasForeignKey(x => x.UserId);
        }
    }
}
