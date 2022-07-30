using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Business.Dto.Product;
using KonusarakOgren.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Get(Guid id)
        {
            var product = await _productRepository.GetById(id);
            //AutoMapper<Product, ProductDto>(product);
            return new ProductDto();
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            return null;
        }

        public async Task<ProductDto> Insert(ProductCreateDto productCreateDto)
        {
            return null;
        }

        public async Task<ProductDto> Update(ProductUpdateDto productUpdateDto)
        {
            return null;
        }

        public async Task Delete(Guid id)
        {
            
        }
    }
}
