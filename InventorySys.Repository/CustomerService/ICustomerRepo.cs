using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.CustomerService
{
    public interface ICustomerRepo
    {
        Task<PaginatedList<CustomerListViewModel>> GetAll(int pageSize,int pageNumber);
    }
}
