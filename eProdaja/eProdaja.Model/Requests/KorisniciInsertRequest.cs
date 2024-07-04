using System.Runtime.CompilerServices;

namespace eProdaja.Model.Requests
{
    public class KorisniciInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }
        //[Compare("PasswordPotvrda", ErrorMessage = "Passwords do not match.")]
        public string Password { get; set; }
        //[Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string PasswordPotvrda { get; set; }
    }
}
