using KonusarakOgren.Business.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Business.Abstract
{
    public interface IProductService
    {
        // Get, GetAll, Insert, Update, Delete
        Task<ProductDto> Get(Guid id);
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> Insert(ProductCreateDto productCreateDto);
        Task<ProductDto> Update(ProductUpdateDto productUpdateDto);
        Task Delete(Guid id);
    }
}
