using AutoMapper;
using Common.DTO;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            EntityToDto();
            DtoToEntity();
        }
        private void EntityToDto()
        {
            CreateMap<User, UserDTO>();
            CreateMap<Discipline, DisciplineDTO>();
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<Reward, RewardDTO>();
            CreateMap<EmployeeSalary, EmployeeSalaryDTO>();
        }
        private void DtoToEntity()
        {
            CreateMap<UserDTO, User>();
            CreateMap<DisciplineDTO, Discipline>();
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<RewardDTO, Reward>();
            CreateMap<EmployeeSalaryDTO, EmployeeSalary>();
        }
    }
}
