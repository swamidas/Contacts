using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contacts
{
    public class Contact
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        [DataType(DataType.Text)]
        public string FName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LName { get; set; }

        [DisplayName("Date Of Birth")]
        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        [UIHint("ListOfHobby")]
        public List<Hobby> Hobbies { get; set; }

        public Address Address { get; set; }

    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Hobby
    {
        Drawing,
        Reading,
        Coding,
        Cricket,
        Carrom,
        Tennis,
        Cooking,
        Movies
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

    }
}