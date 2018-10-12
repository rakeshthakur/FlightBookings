using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService.Model
{
     public class Booking
    {
        //[Key]
        //[ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Key]
        public int BookingId { get; set; }

        [StringLength(25, MinimumLength = 4)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [StringLength(25, MinimumLength = 4)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        public string Name
        {
            get { return FirstName + " ," + LastName; }
        }

        public string Address { get; set; }

        //public AddressViewModel Address { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^[0 - 9]{10}$", @"^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$", @"^[0-9]{3}-[0-9]{4}-[0-9]{4}$",", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}
