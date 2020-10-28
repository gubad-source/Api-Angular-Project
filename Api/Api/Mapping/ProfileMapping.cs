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
            CreateMap<Team, TeamResource>()
                     .ForMember(d => d.Photo, opt => opt.MapFrom(src => BaseUrl + src.Photo));
            CreateMap<First, FirstResource>()
                     .ForMember(d => d.Photo, opt => opt.MapFrom(src => BaseUrl + src.Photo));
            CreateMap<Pricing, PricingResource>()
                   .ForMember(d => d.Photo, opt => opt.MapFrom(src => BaseUrl + src.Photo));
            CreateMap<Services, ServicesResource>()
                   .ForMember(d => d.Photo, opt => opt.MapFrom(src => BaseUrl + src.Photo));
            CreateMap<Fitness, FitnessResource>()
                  .ForMember(d => d.Photo, opt => opt.MapFrom(src => BaseUrl + src.Photo));
            CreateMap<Schedule, ScheduleResource>()
                .ForMember(d => d.Photo, opt => opt.MapFrom(src => BaseUrl + src.Photo));
        }
    }
}
