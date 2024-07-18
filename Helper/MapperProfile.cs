using Mapster;
using OrganizationETMCreation.Dto;
using OrganizationETMCreation.Models;

namespace OrganizationETMCreation.MapperProfile
{
    public static class MappingConfiguration
    {
        public static void RegisterMappings()
        {
            //TypeAdapterConfig<TeamMember, TeamMemberDto>.NewConfig()
            //.Map(dest => dest.TeamName, src => src.Team.Name) // 
            //.Map(dest => dest.EmployeeName, src => src.Employee.Name);

            TypeAdapterConfig<Employee, EmployeeDto>.NewConfig();
            TypeAdapterConfig<EmployeeDto, Employee>.NewConfig();

            TypeAdapterConfig<Team, TeamDto>.NewConfig();
            TypeAdapterConfig<TeamDto, Team>.NewConfig();

            TypeAdapterConfig<TeamMember, TeamMemberDto>.NewConfig();
            TypeAdapterConfig<TeamMemberDto, TeamMember>.NewConfig();

            // Employee mappings
            TypeAdapterConfig<Employee, EmployeeDto>.NewConfig()
                .Map(dest => dest.Id, src => src.Id);
            TypeAdapterConfig<EmployeeDto, Employee>.NewConfig()
                .Map(dest => dest.Id, src => src.Id);

            //// Team mappings
            TypeAdapterConfig<Team, TeamDto>.NewConfig()
                .Map(dest => dest.Id, src => src.EmployeeId);
            TypeAdapterConfig<TeamDto, Team>.NewConfig()
                .Map(dest => dest.EmployeeId, src => src.Id);

            // TeamMember mappings
            TypeAdapterConfig<TeamMember, TeamMemberDto>.NewConfig()
                .Map(dest => dest.memberid, src => src.memberid)
                .Map(dest => dest.memberid, src => src.memberid);

            //Member mappings
            TypeAdapterConfig<Member, MemberDto>.NewConfig()
                .Map(dest => dest.memberid, src => src.memberid);
            TypeAdapterConfig<MemberDto, Member>.NewConfig()
                .Map(dest => dest.memberid, src => src.memberid);
        }
        
    }
}


