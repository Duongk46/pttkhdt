using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface IRewardRepository
    {
        IEnumerable<Reward> SelectAllByStatus();
        IEnumerable<Reward> SelectByQuantityItem(int page, int pageSize);
        long GetTotal();
        IEnumerable<Reward> SelectAll();
        Reward SelectById(object id);
        void Insert(Reward obj);
        Task Update(Reward obj);
        void Delete(object id);
        void DeleteByItem(Reward id);
        void Save();
    }
}
