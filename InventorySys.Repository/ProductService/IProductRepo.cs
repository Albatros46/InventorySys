using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Customer;
using InventorySys.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.Product
{
    public interface IProductRepo
    {
        Task<PaginatedList<ProductListViewModel>> GetAll(int pageSize, int pageNumber);

    }
}
