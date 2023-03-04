using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.CustomerType
{
    public interface ICustomerTypeRepo
    {
        Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int pageSize, int pageNumber);
    }
}
