using InventorySys.Repository.Paging;
using InventorySys.ViewModel.Customer;
using InventorySys.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySys.Repository.CustomerService
{
    public class CustomerRepo : ICustomerRepo
    {
        private ApplicationDbContext _context;

        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<CustomerListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var cutomerList = _context.Customers;
            var vm = cutomerList.CustomerModelToVm().AsQueryable();
            return await PaginatedList<CustomerListViewModel>.CreateAsync(vm,pageSize, pageNumber);
        }
    }
}
