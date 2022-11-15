using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface IEmployeeSalaryRepository
    {
        long GetTotal();
        IEnumerable<EmployeeSalary> SelectByQuantityItem(int page, int pageSize);
        IEnumerable<EmployeeSalary> SelectAll();
        EmployeeSalary SelectById(object id);
        void Insert(EmployeeSalary obj);
        Task Update(EmployeeSalary obj);
        void Delete(object id);
        void DeleteByItem(EmployeeSalary id);
        void Save();
    }
}
