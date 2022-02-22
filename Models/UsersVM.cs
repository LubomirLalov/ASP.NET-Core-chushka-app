using ASPChushka.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPChushka.Models
{
   
    public class UsersVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage ="The username must be between {2} and {1} characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(10, MinimumLength =6, ErrorMessage ="The password must be between {2} and {1} ")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, MinimumLength =5, ErrorMessage ="The Full Name must be between {2} and {1}")]
       
        public string FullName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(320, MinimumLength =5, ErrorMessage ="The email address must be between {2} and {1}")]
        [EmailAddress (ErrorMessage ="The email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [EnumDataType(typeof(Roles))]
        public Roles Role { get; set; }

        [NotMapped]
        public List<SelectListItem> Orders { get; set; }

    }
}
