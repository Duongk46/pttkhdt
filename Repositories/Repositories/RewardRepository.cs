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
    public class RewardRepository : GenericRepository<Reward>, IRewardRepository
    {
        private readonly ManageContext _db;
        public RewardRepository(ManageContext manageContext) : base(manageContext)
        {
            _db = manageContext;
        }
        public IEnumerable<Reward> SelectAllByStatus()
        {
            try
            {
                var model = _db.Rewards.Where(x => x.Status == true).ToList();
                return model;
            } 
            catch
            {
                return null;
            }
        }
        public IEnumerable<Reward> SelectByQuantityItem(int page,int pageSize)
        {
            try
            {
                var model = _db.Rewards.Where(x => x.ID != 0).OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _db.Rewards.Where(x => x.ID != 0).Count();
        }
    }
}
