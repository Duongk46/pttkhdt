using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeeSalaryBusiness
    {
        void Delete(long id);
        IEnumerable<EmployeeSalaryDTO> SelectAll();
        bool EditSalary(EmployeeSalaryDTO employeeSalaryDTO);
        EmployeeSalaryDTO SelectById(long id);
        bool UpdateSalary(EmployeeSalaryDTO employeeSalaryDTO);
        IEnumerable<EmployeeSalaryDTO> SelectByQuantityItem(int page, int pageSize);
        long GetTotal();
    }
}
