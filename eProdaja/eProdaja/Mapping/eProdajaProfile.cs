using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.Mapping;

public class eProdajaProfile : Profile
{
    public eProdajaProfile()
    {
        CreateMap<Database.Korisnici, Model.Korisnici>();
        CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
        CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
        CreateMap<Database.Proizvodi, Model.Proizvodi>();
        CreateMap<Database.Uloge, Model.Uloge>();
        CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
        CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();
        CreateMap<KorisniciInsertRequest, Database.Korisnici>();
    }
}
