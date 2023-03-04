using InventorySys.Models;
using InventorySys.ViewModel.Bill;
using InventorySys.ViewModel.Customer;
using InventorySys.ViewModel.Product;

namespace InventorySys.ViewModel.Mapping
{
    public static class Relationship
    {
        public static IEnumerable<CustomerTypeListViewModel> ModelToVm(this IQueryable<CustomerType> customerType)
        {
            List<CustomerTypeListViewModel> list = new List<CustomerTypeListViewModel>();
            foreach (var ct in customerType)
            {
                list.Add(new CustomerTypeListViewModel()
                {
                    Id = ct.Id,
                    TypeName = ct.TypeName,
                    Description = ct.Description
                });
            }
            return list;
        }

        public static IEnumerable<CustomerListViewModel> CustomerModelToVm(this IEnumerable<InventorySys.Models.Customer> customers)
        {
            List<CustomerListViewModel> list = new List<CustomerListViewModel>();
            foreach (var ct in customers)
            {
                list.Add(new CustomerListViewModel()
                {
                    Id = ct.Id,
                    Name = ct.Name,
                    Email = ct.Email,
                    Phone = ct.Phone,
                    ContaktPerson = ct.ContaktPerson,
                    CustomerTypeId = ct.CustomerTypeId,
                    Adress = ct.Adress,
                    State = ct.State,
                    ZipCode = ct.ZipCode,
                    City = ct.City,
                });
            }
            return list;
        }

        public static IEnumerable<BillTypeListViewModel> BillTypeModelToVm(this IQueryable<InventorySys.Models.BillType> billType)
        {
            List<BillTypeListViewModel> list = new List<BillTypeListViewModel>();
            foreach (var ct in billType)
            {
                list.Add(new BillTypeListViewModel()
                {
                    Id = ct.Id,
                    Name = ct.Name,
                    Description = ct.Description,
                });
            }
            return list;
        }

        public static IEnumerable<BillListViewModel> BillModelToVm(this IQueryable<InventorySys.Models.Bill> bill)
        {
            List<BillListViewModel> list = new List<BillListViewModel>();
            foreach (var ct in bill)
            {
                list.Add(new BillListViewModel()
                {
                   Id=ct.Id,
                   Name = ct.Name,
                   BillTypeId = ct.BillTypeId,  
                   BillDate = ct.BillDate,
                   BillDueDate = ct.BillDueDate,
                   GoodReceivedMotedId = ct.GoodReceivedMotedId,
                   VendorDoNumber = ct.VendorDoNumber,
                   VendorInvoiceNumber = ct.VendorInvoiceNumber 
                });
            }
            return list;
        }

        public static IEnumerable<ProductListViewModel> ProductModelToVm(this IQueryable<InventorySys.Models.Product> products)
        {
            List<ProductListViewModel> list = new List<ProductListViewModel>();
            foreach (var ct in products)
            {
                list.Add(new ProductListViewModel()
                {
                    Id =ct.Id,
                    Name=ct.Name,
                    BranchId = ct.BranchId,
                    BarCode = ct.BarCode,
                    BuyingPrice = ct.BuyingPrice,
                    Code = ct.Code,
                    CurrencyId  = ct.CurrencyId,
                    MasureUnitId = ct.MasureUnitId,
                    Description = ct.Description,
                    SellingPrice = ct.SellingPrice,
                    Image = ct.Image
                });
            }
            return list;
        }

        public static IEnumerable<ProductTypeListViewModel> ProductTypeModelToVm(this IQueryable<InventorySys.Models.ProductType> productTypes)
        {
            List<ProductTypeListViewModel> list = new List<ProductTypeListViewModel>();
            foreach (var ct in productTypes)
            {
                list.Add(new ProductTypeListViewModel()
                {
                   Id=ct.Id,
                   Name =ct.Name,
                   Description=ct.Description,
                });
            }
            return list;
        }

    }
}
