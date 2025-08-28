using System;
using System.Collections.Generic;

namespace TaskApp.API.Models {
    public class Employee {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime LastActive { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}