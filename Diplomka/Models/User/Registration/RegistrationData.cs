﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomka.Models.User.Registration
{
    public class RegistrationData
    {
        [Required(ErrorMessage = "You have not entered the email")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email address is not correct")]
        public string Email { get; set; }

        [Display(Name = "Nickname:")]
        [StringLength(15,MinimumLength = 6, ErrorMessage = "You must specify a nickname between 6 and 15 characters")]
        public string NickName { get; set; }

        [Required(ErrorMessage = "You have not entered the password")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "You must specify a password between 5 and 20 characters")]
        [Compare("PasswordConfirm", ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        [Display(Name = "Confirm password:")]
        public string PasswordConfirm { get; set; }
    }
}