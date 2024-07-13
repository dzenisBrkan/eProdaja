using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace eProdaja.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }
        //[Required(AllowEmptyStrings = false)] //[Compare("PasswordPotvrda", ErrorMessage = "Passwords do not match.")]
        [MinLength(3)]
        public string Password { get; set; }
        //[Required(AllowEmptyStrings = false)] //[Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string PasswordPotvrda { get; set; }
    }
}
