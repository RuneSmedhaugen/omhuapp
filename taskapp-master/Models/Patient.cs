using System;

namespace TaskApp.API.Models {
    public class Patient {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime LastActive { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoUrl { get; set; }
    }
}