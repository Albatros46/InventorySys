using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Mapping;
using InventorySys.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.Product
{
    public class ProductRepo: IProductRepo
    {
        ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<ProductListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var productList = _context.Products;
            var vm = productList.ProductModelToVm().AsQueryable();
            return await PaginatedList<ProductListViewModel>.CreateAsync(vm, pageSize, pageNumber);
        }
    }
}
