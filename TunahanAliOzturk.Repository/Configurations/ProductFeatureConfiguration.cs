using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.Models;

namespace TunahanAliOzturk.Repository.Configurations
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>

    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

           // builder.HasOne(x => x.Product).WithOne(x => x.ProductFeatures).HasForeignKey<ProductFeature>(x=>x.ProductId);

        }
    }
}
