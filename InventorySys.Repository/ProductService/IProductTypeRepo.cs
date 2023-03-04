using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Product;

namespace InventorySys.Repository.Product
{
    public interface IProductTypeRepo
    {
        Task<PaginatedList<ProductTypeListViewModel>> GetAll(int pageSize, int pageNumber);

    }
}
