using InventorySys.Repository.CustomerType;
using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Customer;
using InventorySys.ViewModel.Mapping;

namespace InventorySys.Repository.CustomerTypeService
{
    public class CustomerTypeRepo : ICustomerTypeRepo
    {
        private ApplicationDbContext _context;

        public CustomerTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int pageNumber, int pageSize)
        {
            //throw new NotImplementedException();
            var cutomerTypeList = _context.CustomerTypes;
            var vm = cutomerTypeList.ModelToVm().AsQueryable();
            return await PaginatedList<CustomerTypeListViewModel>.CreateAsync(vm,pageNumber,pageSize);
        }
    }
}
