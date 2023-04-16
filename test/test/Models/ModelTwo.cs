
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

public class ModelTwo
{

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Confirm email is required.")]
    [Compare("Email")]
    [Display(Name = "Confirm Email")]
    public string ConfirmEmail { get; set; }

    [Required(ErrorMessage = "PIN is required.")]
    [RegularExpression("^[0-9]{6}$", ErrorMessage = "Pin must be 6 digits from [0-9]")]
    public string Pin { get; set; }

    [Required(ErrorMessage = "Confirm PIN is required.")]
    [Compare("Pin", ErrorMessage = "PIN and Confirm PIN must match.")]
    [Display(Name = "Confirm Pin")]
    public string ConfirmPin { get; set; }

    [Required(ErrorMessage = "You must accept the terms and conditions.")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "Accept Terms & Conditions is required")]
    public bool AcceptTerms { get; set; }



}