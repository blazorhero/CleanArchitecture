using System.ComponentModel.DataAnnotations;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}