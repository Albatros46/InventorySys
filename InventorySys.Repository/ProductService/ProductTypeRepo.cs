using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Customer;
using InventorySys.ViewModel.Mapping;
using InventorySys.ViewModel.Product;

namespace InventorySys.Repository.Product
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private ApplicationDbContext _context;

        public ProductTypeRepo(ApplicationDbContext context) {  _context = context; }

        public async Task<PaginatedList<ProductTypeListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var productTypeList = _context.ProductTypes;
            var vm=productTypeList.ProductTypeModelToVm().AsQueryable();
            return await PaginatedList<ProductTypeListViewModel>.CreateAsync(vm, pageSize, pageNumber);

        https://www.youtube.com/watch?v=IllQgf5qhNs&list=PLzHIrc5EQ2ssSJafgcf6JnfLx2wgOuIsh&index=8
            Bu ders bitti.
        }
    }
}
