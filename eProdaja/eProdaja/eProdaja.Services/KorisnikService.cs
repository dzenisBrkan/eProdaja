﻿using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.eProdaja.Services;

public class KorisnikService : IKorisnikService
{
    public EProdajaContext _context { get; set; }
    private readonly IMapper _mapper;

    public KorisnikService(EProdajaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<Model.Korisnici> Get(KorisniciSearchRequest request)
    {
        var query = _context.Korisnicis.AsQueryable();

        if (!string.IsNullOrWhiteSpace(request?.Ime))
        {
            query = query.Where(x=>x.Ime.StartsWith(request.Ime));
        }
        if (!string.IsNullOrWhiteSpace(request?.Prezime))
        {
            query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
        }

        var list = query.ToList();
        return _mapper.Map<List<Model.Korisnici>>(list);
    }

    public Model.Korisnici GetById(int id)
    {
        var entity = _context.Korisnicis.Find(id);

        return _mapper.Map<Model.Korisnici>(entity);
    }

    public Model.Korisnici Insert(KorisniciInsertRequest request)
    {
        var entity = _mapper.Map<Database.Korisnici>(request);

        if (request.Password != request.PasswordPotvrda)
        {
            throw new Exception("Unesite isti password");
        }

        entity.LozinkaHash = "test";
        entity.LozinkaSalt = "test";

        _context.Korisnicis.Add(entity);
        _context.SaveChanges();
        return _mapper.Map<Model.Korisnici>(entity);
    }

    public Model.Korisnici Update(int id, KorisniciInsertRequest request)
    {
        var entity = _context.Korisnicis.Find(id);

        _mapper.Map(request, entity);

        if (!string.IsNullOrWhiteSpace(request.Password))
        {
            if(request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slazu!");
            }
            //TODO: update password
        }
        _context.SaveChanges();
        return _mapper.Map<Model.Korisnici>(entity);
    }
}