using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public double Balance { get; set; }
        public string PickUpDay { get; set; }
        public DateTime ExtraPickUpDate { get; set; }
        public DateTime SuspendStartDate { get; set; }
        public DateTime SuspendEndDate { get; set; }
    }
}
