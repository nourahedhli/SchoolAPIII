using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class UserForCreationDto
    {
        [Required(ErrorMessage = "User name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        [MinLength(5, ErrorMessage = "Minimum length for the Name is 5 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the first name is 60 characters.")]
        [MinLength(1, ErrorMessage = "Minimum length for the first name is 1 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Country is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the last name is 60 characters.")]
        [MinLength(1, ErrorMessage = "Minimum length for the last name is 1 characters.")]
        public string LastName { get; set; }
    }
}