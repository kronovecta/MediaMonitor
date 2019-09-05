using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MediaMonitor.Domain.Entities;
using MediaMonitor.Application.DtoObjects;

namespace MediaMonitor.Infrastructure
{
    public class KodiProfile : Profile
    {
        public KodiProfile()
        {
            CreateMap<Movie, MovieDto>()
                .ForMember(x => x.LocalTitle, opt => opt.MapFrom(src => src.C00))
                .ForMember(x => x.DescriptionLong, opt => opt.MapFrom(src => src.C01))
                .ForMember(x => x.DescriptionShort, opt => opt.MapFrom(src => src.C02))
                .ForMember(x => x.Writer, opt => opt.MapFrom(src => src.C06))
                .ForMember(x => x.Thumbnail, opt => opt.MapFrom(src => src.C08))
                .ForMember(x => x.IMDB_ID, opt => opt.MapFrom(src => src.C09))
                .ForMember(x => x.RunTime, opt => opt.MapFrom(src => src.C11))
                .ForMember(x => x.Genre, opt => opt.MapFrom(src => src.C14))
                .ForMember(x => x.Director, opt => opt.MapFrom(src => src.C15))
                .ForMember(x => x.Studio, opt => opt.MapFrom(src => src.C18))
                .ForMember(x => x.YouTubeTrailerId, opt => opt.MapFrom(src => src.C19))
                .ForMember(x => x.FanartUrl, opt => opt.MapFrom(src => src.C20))
                .ForMember(x => x.Country, opt => opt.MapFrom(src => src.C21));
        }
    }
}
