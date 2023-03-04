using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.DTOs;
using TunahanAliOzturk.Core.Models;
using TunahanAliOzturk.Core.Repositories;
using TunahanAliOzturk.Core.Services;
using TunahanAliOzturk.Core.UnitOfWorks;

namespace TunahanAliOzturk.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _produductRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork,IMapper mapper, IProductRepository productRepository):base(repository,unitOfWork)
        {
            _produductRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<List<ProductWithCategoryDto>> GetProductsWithCategory()
        {
            var products = await _produductRepository.GetProductsWithCategory();

            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);

            return productsDto;
        }
    }
}
