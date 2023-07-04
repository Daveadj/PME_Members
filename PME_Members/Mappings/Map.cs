using AutoMapper;
using PME_Members.Data;
using PME_Members.Model;

namespace PME_Members.Mappings
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Member, MemberModel>().ReverseMap();
            CreateMap<Member, DetailedModel>().ReverseMap();
            CreateMap<MemberModel, DetailedModel>().ReverseMap();
        }
    }
}