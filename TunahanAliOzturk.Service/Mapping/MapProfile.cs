using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunahanAliOzturk.Core.DTOs;
using TunahanAliOzturk.Core.Models;

namespace TunahanAliOzturk.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
        }
    }
}
