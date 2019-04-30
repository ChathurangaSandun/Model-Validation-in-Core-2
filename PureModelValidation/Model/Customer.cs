using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PureModelValidation.Model
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required (ErrorMessage = "Email is required")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}
