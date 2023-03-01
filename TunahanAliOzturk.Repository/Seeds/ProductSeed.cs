using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.Models;

namespace TunahanAliOzturk.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Computer",
                    Price = 15000,
                    Stock = 20,
                    CreateDate = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Phone",
                    Price = 4000,
                    Stock = 40,
                    CreateDate = DateTime.Now
                },
                 new Product
                 {
                     Id = 3,
                     CategoryId = 2,
                     Name = "Cheese",
                     Price = 10,
                     Stock = 20,
                     CreateDate = DateTime.Now
                 },
                  new Product
                  {
                      Id = 4,
                      CategoryId = 2,
                      Name = "Bread",
                      Price = 5,
                      Stock = 100,
                      CreateDate = DateTime.Now
                  });
        }
    }
}
