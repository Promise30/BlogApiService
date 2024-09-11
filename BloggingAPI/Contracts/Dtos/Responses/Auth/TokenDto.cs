﻿namespace BloggingAPI.Contracts.Dtos.Responses.Auth
{
    public class TokenDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime AccessTokenExpiryDate { get; set; }
        public DateTime? RefreshTokenExpiryDateExpiry { get; set; }
    }
}
