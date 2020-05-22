namespace BMESRestApi.Models.Customer
{
    using System.Collections.Generic;
    using Shared;
    using Address;
    using Order;
    using System.ComponentModel.DataAnnotations;

    public class Customer : BaseObject
    {
        [Key]
        public int CustomerID { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
