using AutoMapper;

namespace eProdaja.Mapping;

public class eHotelProfile : Profile
{
    public eHotelProfile()
    {
        CreateMap<Database.Korisnici, Model.Korisnici>();
        CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
        CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
    }
}
