using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.Models;

namespace TunahanAliOzturk.Core.Repositories
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {

        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
