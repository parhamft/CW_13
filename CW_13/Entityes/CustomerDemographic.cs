using System.Security.Principal;

namespace CW_13.Entityes
{
    public class CustomerDemographic
    {
        public string CustomerTypeId { get; set; }

        public string? CustomerDesc { get; set; }
        public List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
