using AutoMapper;
using PersonelProject.DTOs;
using PersonelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Mappers
{
    public class MapperProfiles: Profile
    {
        public MapperProfiles()
        {
            CreateMap<Sehir, SehirDTO>().
        ForMember(dest => dest.sehirAd, opt => opt.MapFrom(src => src.SehirAd)).
        ForMember(dest => dest.sehirId, opt => opt.MapFrom(src => src.SehirId)).
        ForMember(dest => dest.resimYol, opt => opt.MapFrom(src => src.ResimYol));

            CreateMap<SehirDTO, Sehir>().
        ForMember(dest => dest.SehirAd, opt => opt.MapFrom(src => src.sehirAd)).
        ForMember(dest => dest.SehirId, opt => opt.MapFrom(src => src.sehirId)).
        ForMember(dest => dest.ResimYol, opt => opt.MapFrom(src => src.resimYol));
        }
    }
}
