using AutoMapper;

namespace AutoMapper_Test.Data
{
    public class MapperTest : Profile
    {
        public MapperTest() 
        {
            CreateMap<ViewEmployee, Employee>()
                .ForMember(emp => emp.FullName, opt => opt.MapFrom(src => $"{src.Name} {src.LastName}"));
        }
    }
}
