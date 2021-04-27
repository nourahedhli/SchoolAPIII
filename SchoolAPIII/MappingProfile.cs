using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPIII
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Organization, OrganizationDto>()
                    .ForMember(c => c.FullAddress,
                        opt => opt.MapFrom(x => string.Join(", ", x.City, x.Country)));

            CreateMap<User, UserDto>()
                    .ForMember(c => c.FullName,
                        opt => opt.MapFrom(x => string.Join(", ", x.FirstName, x.LastName)));

            CreateMap<OrganizationForCreationDto, Organization>();
            CreateMap<OrganizationForUpdateDto, Organization>();

            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}