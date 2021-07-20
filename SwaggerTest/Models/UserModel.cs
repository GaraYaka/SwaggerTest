using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is required")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public List<Address> Address { get; set; }
    }

    public class Address
    {
        [Required]
        public AddressType AddressType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public enum AddressType
    {
        BillTo = 0,
        ShipTo = 1
    }

}
