using System;
using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformsService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            //source --> Target

            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}

