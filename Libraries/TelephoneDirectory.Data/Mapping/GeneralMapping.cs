using AutoMapper;
using TelephoneDirectory.Libraries.Core;

namespace TelephoneDirectory.Libraries.Data
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ReportCollection, ReportDto>().ReverseMap();
            CreateMap<ReportCollection, ReportCreateDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, ContactCreateDto>().ReverseMap();
        }
    }
}
