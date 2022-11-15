using AutoMapper;
using Business.Interfaces;
using Common.DTO;
using Entities.Entities;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeBusiness(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public EmployeeDTO SelectById(long? id)
        {
            var employee = _employeeRepository.SelectById(id);
            var employeeDto = _mapper.Map<Employee, EmployeeDTO>(employee);
            return employeeDto;
        }
        public IEnumerable<EmployeeDTO> SelectAll()
        {
            var Employees = _employeeRepository.SelectAll();
            var EmployeeDtos = Employees.Select(item => _mapper.Map<Employee, EmployeeDTO>(item));
            return EmployeeDtos;
        }
        public bool DeleteEmployee(long id)
        {
            _employeeRepository.Delete(id);
            _employeeRepository.Save();
            return true;
        }
        public bool EditEmployee(EmployeeDTO employeeDTO)
        {
            var check = false;
            check = _employeeRepository.CheckEmail(employeeDTO.Email);
            var email = _employeeRepository.GetEmailById(employeeDTO.ID);
            if (check || email == employeeDTO.Email)
            {
                var employee = new Employee();
                employee = _mapper.Map<EmployeeDTO, Employee>(employeeDTO);
                employee.Status = true;
                _employeeRepository.Update(employee);
                _employeeRepository.Save();
                return true;
            }
            return false;
        }

        public bool CreateEmployee(EmployeeDTO employeeDTO)
        {
            employeeDTO.CreatedDate = DateTime.Now;
            employeeDTO.Status = true;
            if (_employeeRepository.CheckEmail(employeeDTO.Email))
            {
                var employee = new Employee();
                employee = _mapper.Map<EmployeeDTO, Employee>(employeeDTO);
                _employeeRepository.Insert(employee);
                _employeeRepository.Save();
                return true;
            }
            return false;
        }
        public EmployeeDTO GetEmployeeById(long id)
        {
            var Employee = _employeeRepository.SelectById(id);
            var EmployeeDto = _mapper.Map<Employee, EmployeeDTO>(Employee);
            return EmployeeDto;
        }
        public IEnumerable<EmployeeDTO> SelectByQuantityItem(int page,int pageSize)
        {
            var employees = _employeeRepository.SelectByQuantityItem(page, pageSize);
            var employeeDtos = employees.Select(item => _mapper.Map<Employee, EmployeeDTO>(item));
            return employeeDtos;
        }
        public long GetTotal()
        {
            return _employeeRepository.GetTotal();
        }
    }
}
