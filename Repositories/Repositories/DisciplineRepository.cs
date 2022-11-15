using Entities.Entities;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class DisciplineRepository : GenericRepository<Discipline>,IDisciplineRepository
    {
        private readonly ManageContext _db;
        public DisciplineRepository(ManageContext manageContext) : base(manageContext)
        {
            _db = manageContext;
        }
        public IEnumerable<Discipline> SelectAllByStatus()
        {
            try
            {
                var model = _db.Disciplines.Where(x => x.Status == true).ToList();
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Discipline> SelectByQuantityItem(int page, int pageSize)
        {
            try
            {
                var model = _db.Disciplines.Where(x => x.ID != 0).OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _db.Disciplines.Where(x => x.ID != 0).Count();
        }
    }
}
