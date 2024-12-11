using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? FullName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(20)]
        public string? RG { get; set; }

        [Required]
        [StringLength(20)]
        public string? CPF { get; set; }

        [StringLength(10)]
        public string? ZIPCode { get; set; }

        [StringLength(100)]
        public string? Address { get; set; }

        [StringLength(100)]
        public string? Neighborhood { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        public string? Complement { get; set; }

        [Required]
        public string? MaritalStatus { get; set; }

        [StringLength(100)]
        public string? FatherName { get; set; }

        [StringLength(100)]
        public string? MotherName { get; set; }
    }
}
