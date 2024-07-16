using System.ComponentModel.DataAnnotations;

namespace eProdaja.Model.Requests
{
    public class ProizvodiInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Sifra { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Cijena { get; set; }
        public int VrstaId { get; set; }
        public int JedinicaMjereId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Status { get; set; }
    }
}