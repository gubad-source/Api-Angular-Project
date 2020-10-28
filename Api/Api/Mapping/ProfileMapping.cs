using Api.Resources;
using AutoMapper;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mapping
{
    public class ProfileMapping : Profile
    {
        private static string BaseUrl = "https://localhost:44354/img/";
        public ProfileMapping()
        {
            CreateMap<Slider,SliderResource>();
            CreateMap<Cards, CardsResource>()
                     .ForMember(d => d.Photo, opt => opt.MapFrom(src=>BaseUrl+src.Photo));
        }
    }
}
