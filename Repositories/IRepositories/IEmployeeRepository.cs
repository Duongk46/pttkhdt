using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface IEmployeeRepository
    {
        string GetEmailById(long id);
        bool CheckEmail(string Email);
        long GetTotal();
        IEnumerable<Employee> SelectByQuantityItem(int page, int pageSize);
        IEnumerable<Employee> SelectAll();
        Employee SelectById(object id);
        void Insert(Employee obj);
        Task Update(Employee obj);
        void Delete(object id);
        void DeleteByItem(Employee id);
        void Save();
    }
}
