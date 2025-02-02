﻿using System.ComponentModel.DataAnnotations;

namespace eProdaja.Model.Requests
{
    public class KorisniciUpdateRequest
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
    }
}