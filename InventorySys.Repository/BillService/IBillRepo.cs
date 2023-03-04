using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Bill;
using InventorySys.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.BillService
{
    public interface IBillRepo
    {
        Task<PaginatedList<BillListViewModel>> GetAll(int pageSize, int pageNumber);
    }
}
