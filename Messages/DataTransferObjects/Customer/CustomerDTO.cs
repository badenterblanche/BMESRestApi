using System;
using System.Collections.Generic;
using BMESRestApi.Messages.DataTransferObjects.Address;
using BMESRestApi.Messages.DataTransferObjects.Order;

namespace BMESRestApi.Messages.DataTransferObjects.Customer
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public string DateOfBirth { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<OrderDTO> Orders { get; set; }
        public IEnumerable<AddressDTO> Addresses { get; set; }
    }
}
