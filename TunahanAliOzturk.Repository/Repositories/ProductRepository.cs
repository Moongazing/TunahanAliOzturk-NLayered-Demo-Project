using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.Models;
using TunahanAliOzturk.Core.Repositories;

namespace TunahanAliOzturk.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context):base(context)
        {

        }
        public async Task<List<Product>> GetProductsWithCategory()
        {
            //Eager loading
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
