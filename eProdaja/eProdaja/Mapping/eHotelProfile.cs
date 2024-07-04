using AutoMapper;
using eProdaja.Model.Requests;

namespace eProdaja.Mapping;

public class eHotelProfile : Profile
{
    public eHotelProfile()
    {
        CreateMap<Database.Korisnici, Model.Korisnici>();
        CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
        CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
        CreateMap<Database.Proizvodi, Model.Proizvodi>();
        CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
        CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();
        CreateMap<KorisniciInsertRequest, Database.Korisnici>();
    }
}
