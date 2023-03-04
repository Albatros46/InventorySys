using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Bill;
using InventorySys.ViewModel.Mapping;

namespace InventorySys.Repository.BillService
{
    public class BillRepo : IBillRepo
    {
        private ApplicationDbContext _context;
        public BillRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<BillListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var billList = _context.Bills;
            var vm = billList.BillModelToVm().AsQueryable();
            return await PaginatedList<BillListViewModel>.CreateAsync(vm, pageSize, pageNumber);
        }
    }
}
