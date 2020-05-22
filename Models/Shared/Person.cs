using System.ComponentModel.DataAnnotations;

namespace BMESRestApi.Models.Shared
{
    public class Person : BaseObject
    {
        [Key]
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string DateOfBirth { get; set; }
    }
}
