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
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }
    }
}
