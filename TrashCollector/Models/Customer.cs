using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        public double Balance { get; set; }
        
        [Display(Name = "Pick-Up Day")]
        public string PickUpDay { get; set; }   //could use DayOfWeek
        
        [Display(Name = "Extra Pick-Up Date")]
        public DateTime? ExtraPickUpDate { get; set; }
        
        [Display(Name = "Suspend Pick-Up Start Date")]
        public DateTime? SuspendStartDate { get; set; } //Could use TimeSpan?

        [Display(Name = "Suspend Pick-Up End Date")]
        public DateTime? SuspendEndDate { get; set; }

        [Display(Name = "Confirm Suspension")]
        public bool IsSuspended { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }

}
