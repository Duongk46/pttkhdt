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
    public class EmployeeSalaryBusiness : IEmployeeSalaryBusiness
    {
        private readonly IEmployeeSalaryRepository _employeeSalaryRepository;
        private readonly IMapper _mapper;
        public EmployeeSalaryBusiness(IEmployeeSalaryRepository employeeSalaryRepository,
            IMapper mapper
            )
        {
            _employeeSalaryRepository = employeeSalaryRepository;
            _mapper = mapper;

        }
        public void Delete(long id)
        {
            _employeeSalaryRepository.Delete(id);
        }
        public IEnumerable<EmployeeSalaryDTO> SelectAll()
        {
            var employeeSalarys = _employeeSalaryRepository.SelectAll();
            var employeeSalaryDtos = employeeSalarys.Select(item => _mapper.Map<EmployeeSalary, EmployeeSalaryDTO>(item));
            return employeeSalaryDtos;
        }
        public bool EditSalary(EmployeeSalaryDTO employeeSalaryDTO)
        {
            var salary = new EmployeeSalary();
            salary = _mapper.Map<EmployeeSalaryDTO, EmployeeSalary>(employeeSalaryDTO);
            _employeeSalaryRepository.Update(salary);
            _employeeSalaryRepository.Save();
            return true;
        }
        public EmployeeSalaryDTO SelectById(long id)
        {
            var salary = _employeeSalaryRepository.SelectById(id);
            var salaryDto = _mapper.Map<EmployeeSalary, EmployeeSalaryDTO>(salary);
            return salaryDto;
        }
        public bool UpdateSalary(EmployeeSalaryDTO employeeSalaryDTO)
        {
            var salary = new EmployeeSalary();
            salary = _mapper.Map<EmployeeSalaryDTO, EmployeeSalary>(employeeSalaryDTO);
            salary.CreatedDate = DateTime.Now;
            _employeeSalaryRepository.Insert(salary);
            _employeeSalaryRepository.Save();
            return true;
        }
        public IEnumerable<EmployeeSalaryDTO> SelectByQuantityItem(int page,int pageSize)
        {
            var employeeSalarys = _employeeSalaryRepository.SelectByQuantityItem(page, pageSize);
            var employeeSalaryDtos = employeeSalarys.Select(item => _mapper.Map<EmployeeSalary, EmployeeSalaryDTO>(item));
            return employeeSalaryDtos;
        }
        public long GetTotal()
        {
            return _employeeSalaryRepository.GetTotal();
        }
    }
}
