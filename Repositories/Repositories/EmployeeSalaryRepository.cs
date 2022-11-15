using Entities.Entities;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class EmployeeSalaryRepository : GenericRepository<EmployeeSalary>, IEmployeeSalaryRepository
    {
        private readonly ManageContext _db;
        public EmployeeSalaryRepository(ManageContext manageContext) : base(manageContext)
        {
            _db = manageContext;
        }
        public IEnumerable<EmployeeSalary> SelectByQuantityItem(int page,int pageSize)
        {
            try
            {
                var model = _db.EmployeeSalaries.Where(x => x.ID != 0).OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _db.EmployeeSalaries.Where(x => x.ID != 0).Count();
        }
    }
}
