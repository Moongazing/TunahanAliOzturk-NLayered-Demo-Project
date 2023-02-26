using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.Entities;

namespace TunahanAliOzturk.Repository.Seeds
{
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id=1,
                    Color = "Black",
                    Height = 15,
                    Width = 9,
                    ProductId = 1
                },
                new ProductFeature
                {
                    Id = 2,
                    Color = "White",
                    Height = 13,
                    Width = 2,
                    ProductId = 2
                },
                new ProductFeature
                {
                    Id = 3,
                    Color = "White",
                    Height = 15,
                    Width = 9,
                    ProductId = 3
                },
                  new ProductFeature
                  {
                      Id = 4,
                      Color = "-",
                      Height = 10,
                      Width = 10,
                      ProductId = 4
                  });
        }
    }
}
