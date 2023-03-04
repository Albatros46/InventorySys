using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Bill;
using InventorySys.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.BillTypeService
{
    public interface IBillTypeRepo
    {
        Task<PaginatedList<BillTypeListViewModel>> GetAll(int pageSize, int pageNumber);

    }
}
