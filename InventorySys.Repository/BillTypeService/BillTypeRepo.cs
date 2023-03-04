using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Bill;
using InventorySys.ViewModel.Customer;
using InventorySys.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.BillTypeService
{
    public class BillTypeRepo : IBillTypeRepo
    {
        private ApplicationDbContext _context;

        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<BillTypeListViewModel>> GetAll(int pageSize, int pageNumber)
        {
          
            var billTypeList = _context.BillTypes;
            var vm=billTypeList.BillTypeModelToVm().AsQueryable();
            return await PaginatedList<BillTypeListViewModel>.CreateAsync(vm, pageSize, pageNumber);
        }
    }
}
