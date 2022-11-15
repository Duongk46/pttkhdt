using Common.DTO;
using Mvc.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Mapper
{
    public class DtoViewModel
    {
        public EmployeeSalaryDTO EmployeeSalaryViewModelToDto(EmployeeSalaryViewModel employeeSalaryViewModel)
        {
            var employeeSalaryDTO = new EmployeeSalaryDTO()
            {
                ID = employeeSalaryViewModel.ID,
                CreatedDate = employeeSalaryViewModel.CreatedDate,
                Salary = employeeSalaryViewModel.Salary,
                CreatedBy = employeeSalaryViewModel.CreatedBy,
                IDEmployee = employeeSalaryViewModel.IDEmployee,
                Status = employeeSalaryViewModel.Status,
            };
            return employeeSalaryDTO;
        }
        public EmployeeSalaryViewModel EmployeeSalaryDtoToViewModel(EmployeeSalaryDTO employeeSalaryDTO)
        {
            var employeeSalaryViewModel = new EmployeeSalaryViewModel()
            {
                ID = employeeSalaryDTO.ID,
                CreatedDate = employeeSalaryDTO.CreatedDate,
                Salary = employeeSalaryDTO.Salary,
                CreatedBy = employeeSalaryDTO.CreatedBy,
                IDEmployee = employeeSalaryDTO.IDEmployee,
                Status = employeeSalaryDTO.Status,
            };
            return employeeSalaryViewModel;
        }
        public DisciplineDTO DisciplineViewModelToDto(DisciplineViewModel disciplineViewModel)
        {
            var disciplineDto = new DisciplineDTO()
            {
                ID = disciplineViewModel.ID,
                Name = disciplineViewModel.NameDiscipline,
                Money = disciplineViewModel.Money,
                CreatedBy = disciplineViewModel.CreatedBy,
                CreatedDate = disciplineViewModel.CreatedDate,
                Status = disciplineViewModel.Status,
                IDEmployee = disciplineViewModel.IDEmployee,
            };
            return disciplineDto;
        }
        public DisciplineViewModel DisciplineDtoToViewModel(DisciplineDTO disciplineDTO)
        {
            var disciplineViewModel = new DisciplineViewModel()
            {
                ID = disciplineDTO.ID,
                NameDiscipline = disciplineDTO.Name,
                Money = disciplineDTO.Money,
                CreatedBy = disciplineDTO.CreatedBy,
                Status = disciplineDTO.Status,
                CreatedDate = disciplineDTO.CreatedDate,
                IDEmployee = disciplineDTO.IDEmployee
            };
            return disciplineViewModel;
        }
        public RewardDTO RewardViewModelToDto(RewardViewModel rewardViewModel)
        {
            var RewardDto = new RewardDTO()
            {   
                ID = rewardViewModel.ID,
                Name = rewardViewModel.NameReward,
                Money = rewardViewModel.Money,
                CreatedBy = rewardViewModel.CreatedBy,
                CreatedDate = rewardViewModel.CreatedDate,
                Status = rewardViewModel.Status,
                IDEmployee = rewardViewModel.IDEmployee,
            };
            return RewardDto;
        }
        public RewardViewModel RewardDtoToViewModel(RewardDTO rewardDTO)
        {
            var RewardViewModel = new RewardViewModel()
            {
                ID = rewardDTO.ID,
                NameReward = rewardDTO.Name,
                Money = rewardDTO.Money,
                CreatedBy = rewardDTO.CreatedBy,
                Status = rewardDTO.Status,
                CreatedDate = rewardDTO.CreatedDate,
                IDEmployee = rewardDTO.IDEmployee
            };
            return RewardViewModel;
        }
        public EmployeeDTO EmployeeViewModelToDto(EmployeeViewModel employeeViewModel)
        {
            var employeeDto = new EmployeeDTO()
            {
                ID = employeeViewModel.ID,
                Name = employeeViewModel.Name,
                Address = employeeViewModel.Address,
                BirthDay = employeeViewModel.BirthDay,
                Phone = employeeViewModel.Phone,
                Email = employeeViewModel.Email,
                CreatedBy = employeeViewModel.CreatedBy,
                CreatedDate = employeeViewModel.CreatedDate,
                Sex = employeeViewModel.Sex,
                Type = int.Parse(employeeViewModel.Type),
                Status = employeeViewModel.Status,
            };
            return employeeDto;
        }
        public EmployeeViewModel EmployeeDtoToViewModel(EmployeeDTO employeeDTO)
        {
            var employeeViewModel = new EmployeeViewModel()
            {
                ID = employeeDTO.ID,
                Name = employeeDTO.Name,
                Address = employeeDTO.Address,
                Phone = employeeDTO.Phone,
                Email = employeeDTO.Email,
                BirthDay = employeeDTO.BirthDay,
                CreatedBy = employeeDTO.CreatedBy,
                CreatedDate = employeeDTO.CreatedDate,
                Sex = employeeDTO.Sex,
                Type = employeeDTO.Type.ToString(),
                Status = employeeDTO.Status,
            };
            return employeeViewModel;
        }
        public UserViewModel UserDtoToUserViewModel(UserDTO userDto)
        {
            var userViewModel = new UserViewModel()
            {
                ID = userDto.ID,
                Username = userDto.Username,
                Password = userDto.Password,
                Name = userDto.Name,
                Address = userDto.Address,
                Phone = userDto.Phone,
                Email = userDto.Email,
                CreatedDate = userDto.CreatedDate,
                BirthDay = userDto.BirthDay,
                UserType = userDto.UserType,
                Sex = userDto.Sex,
                Status = userDto.Status,
            };
            return userViewModel;
        }
        public UserDTO UserViewModelToUserDto(UserViewModel userViewModel)
        {
            var UserDto = new UserDTO()
            {
                ID = userViewModel.ID,
                Username = userViewModel.Username,
                Password = userViewModel.Password,
                Name = userViewModel.Name,
                Address = userViewModel.Address,
                Phone = userViewModel.Phone,
                Email = userViewModel.Email,
                BirthDay = userViewModel.BirthDay,
                UserType = userViewModel.UserType,
                Sex = userViewModel.Sex,
                Status = userViewModel.Status,
            };
            return UserDto;
        }
    }
}
