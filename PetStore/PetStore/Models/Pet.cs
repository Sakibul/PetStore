using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public enum Breed
    {
        [Description("Dog")]
        Dog,

        [Description("Cat")]
        Cat,

        [Description("Fish")]
        Fish,

        [Description("Hamster")]
        Hamster,

        [Description("Guinea Pig")]
        GuineaPig
    }

    public class Pet
    {
        public int ID { get; set; }

        
        public int OwnerID { get; set; }


        [Required, MaxLength(10, ErrorMessage = "Name cannot be greater than 20 characters")]
        public string Name { get; set; }


        [Required]
        public DateTime DOB { get; set; }


        public Owner Owner { get; set; }
        // Navigation property that define the relation 1 Pet – 1 Owner
    }
}
