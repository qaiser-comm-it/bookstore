using Acme.Bookstore.Authors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.Bookstore.Configurations
{
    public class AuthorEntityConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable(BookstoreConsts.DbTablePrefix + "Authors", BookstoreConsts.DbSchema);
            builder.ConfigureByConvention();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(AuthorConsts.MaxNameLength);
            builder.HasIndex(x => x.Name);
        }
    }
}
