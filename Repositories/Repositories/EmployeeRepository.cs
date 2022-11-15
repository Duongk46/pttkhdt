using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ManageContext _db;
        public EmployeeRepository(ManageContext manageContext) : base(manageContext)
        {
            _db = manageContext;
        }
        public string GetEmailById(long id)
        {
            return _db.Employees.SingleOrDefault(x => x.ID == id).Email;
        }
        public bool CheckEmail(string Email)
        {
            var model = _db.Employees.SingleOrDefault(e => e.Email == Email);
            return ((model == null) ? true : false);
        }
        public IEnumerable<Employee> SelectByQuantityItem(int page,int pageSize)
        {
            try
            {
                var model = _db.Employees.Where(x => x.ID != 0).OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _db.Employees.Where(x => x.ID != 0).Count();
        }
    }
}
