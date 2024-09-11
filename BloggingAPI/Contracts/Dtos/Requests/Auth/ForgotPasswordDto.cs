﻿using System.ComponentModel.DataAnnotations;

namespace BloggingAPI.Contracts.Dtos.Requests.Auth
{
    public class ForgotPasswordDto
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "A valid email address is required")]
        public string Email { get; set; }
    }
}
