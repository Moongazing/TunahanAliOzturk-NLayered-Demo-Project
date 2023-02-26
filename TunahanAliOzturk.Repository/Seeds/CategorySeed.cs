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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Product { Id = 1 ,Name = "Technology" }, 
                new Product { Id = 2, Name = "Food" });
        }
    }
}
