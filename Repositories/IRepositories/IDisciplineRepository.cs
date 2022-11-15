using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface IDisciplineRepository
    {
        IEnumerable<Discipline> SelectAllByStatus();
        long GetTotal();
        IEnumerable<Discipline> SelectByQuantityItem(int page, int pageSize);
        IEnumerable<Discipline> SelectAll();
        Discipline SelectById(object id);
        void Insert(Discipline obj);
        Task Update(Discipline obj);
        void Delete(object id);
        void DeleteByItem(Discipline id);
        void Save();
    }
}
