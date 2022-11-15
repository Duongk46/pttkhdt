using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeeBusiness
    {
        EmployeeDTO SelectById(long? id);
        IEnumerable<EmployeeDTO> SelectAll();
        bool DeleteEmployee(long id);
        bool EditEmployee(EmployeeDTO employeeDTO);
        bool CreateEmployee(EmployeeDTO employeeDTO);
        EmployeeDTO GetEmployeeById(long id);
        long GetTotal();
        IEnumerable<EmployeeDTO> SelectByQuantityItem(int page, int pageSize);
    }
}
