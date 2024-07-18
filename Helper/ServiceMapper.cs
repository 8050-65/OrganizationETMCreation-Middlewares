//using Mapster;
//using Mapster;
//using OrganizationETMCreation.Dto;
//using OrganizationETMCreation.Models;

//namespace OrganizationETMCreation.ServiceMapper
//{
//    public class MappingConfig
//    {
//        public static void RegisterMappings()
//        {
//            TypeAdapterConfig<Employee, EmployeeDto>.NewConfig();
//            TypeAdapterConfig<EmployeeDto, Employee>.NewConfig();

//            TypeAdapterConfig<Team, TeamDto>.NewConfig();
//            TypeAdapterConfig<TeamDto, Team>.NewConfig();

//            TypeAdapterConfig<TeamMember, TeamMemberDto>.NewConfig();
//            TypeAdapterConfig<TeamMemberDto, TeamMember>.NewConfig();
//        }
//    }
//}
//public class MapperProfile
//{
//    public MapperProfile()
//    {
//        CreateMap<Team, TeamDto>();
//        CreateMap<TeamDto, Team>();
//        CreateMap<TeamMember, TeamMemberDto>();
//        CreateMap<TeamMemberDto, TeamMember>();
//    }
//}
//public class MapperProfile : Profile
//{
//    public MapperProfile()
//    {
//        CreateMap<Employee, EmployeeDto>();
//        CreateMap<EmployeeDto, Employee>();

//        CreateMap<Team, TeamDto>();
//        CreateMap<TeamDto, Team>();

//        CreateMap<TeamMember, TeamMemberDto>();
//        CreateMap<TeamMemberDto, TeamMember>();
//    }
//}