﻿using AnalogTrello.Models;
using AnalogTrelloBE.Dto;
using AutoMapper;

namespace AnalogTrelloBE.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
    
}