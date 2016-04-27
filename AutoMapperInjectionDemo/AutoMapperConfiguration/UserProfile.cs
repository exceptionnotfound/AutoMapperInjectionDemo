using AutoMapper;
using AutoMapperInjectionDemo.Lib;
using AutoMapperInjectionDemo.Lib.Models.Database;
using AutoMapperInjectionDemo.Lib.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperInjectionDemo.AutoMapperConfiguration
{
    public class UserProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<DbUser, User>().ForMember(dest => dest.AccessLevel, opt => opt.MapFrom(src => (AccessLevel)src.AccessLevelID));
        }
    }
}