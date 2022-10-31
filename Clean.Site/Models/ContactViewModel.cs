using System.ComponentModel.DataAnnotations;
using Umbraco.Cms.Web.Common.PublishedModels;
namespace Clean.Site.Models;

public class ContactViewModel
{
    [Required(ErrorMessage = "Please enter your name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter the subject of the email")]
    [MaxLength(100, ErrorMessage = "Your subject must be no longer than 100 symbols")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Please enter the message")]
    [MaxLength(500, ErrorMessage = "Your message must be no longer than 500 symbols")]
    public string Message { get; set; }
}