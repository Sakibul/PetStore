using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Owner
    {
        public int ID { get; set; }


        [Required, MaxLength(20, ErrorMessage = "First Name cannot be greater than 20 characters")]
        public string FirstName { get; set; }


        [Required, MaxLength(20, ErrorMessage = "Last Name cannot be greater than 20 characters")]
        public string LastName { get; set; }


        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;
        // [NotMapped] means this property is not updated in the Database


        [Required, MaxLength(20, ErrorMessage = "Street cannot be greater than 20 characters")]
        public string Street { get; set; }


        [Required, MaxLength(20, ErrorMessage = "City cannot be greater than 20 characters")]
        public string City { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please input Email Address")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string EmailAddress { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please input Phone Number")]
        public string PhoneNumber { get; set; }


        [Required, MaxLength(20, ErrorMessage = "Occupation cannot be greater than 20 characters")]
        public string Occupation { get; set; }


        public ICollection<Pet> Pets { get; set; }
        // Relationship: Owner(1) VS Pet (Many)
        // Navigation property that define the relation 1 Owner – many Pets
    }
}
