﻿using AutoMapper;

namespace TaskTrackerData.Profiles
{
    public class SignUpProfile : Profile
    {
        public SignUpProfile()
        {
            CreateMap<Domain.User, Common.Contract.Model.UserDto>();
            CreateMap<Common.Contract.Model.UserForUpdateDto, Domain.User>();
            CreateMap<Domain.User, Common.Contract.Model.UserForUpdateDto>();
        }
    }
}
