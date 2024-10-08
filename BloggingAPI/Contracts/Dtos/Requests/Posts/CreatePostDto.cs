﻿using BloggingAPI.Contracts.Validations;
using BloggingAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BloggingAPI.Contracts.Dtos.Requests.Posts
{
    public class CreatePostDto
    {
        [Required(ErrorMessage = "A post title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A post content is required")]
        public string? Content { get; set; }
        [AllowedFileExtensions(new[] { ".jpg", ".png", ".jpeg" }, ErrorMessage = "Only JPG, JPEG and PNG files are allowed")]
        [MaxFileSize(2 * 1024 * 1024, ErrorMessage = "File size must not exceed 2 MB")]
        public IFormFile? PostCoverImage { get; set; }
        public List<int>? TagsId { get; set; } = new List<int>();
    }
}
