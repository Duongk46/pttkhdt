using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRewardBusiness
    {
        IEnumerable<RewardDTO> SelectAll();
        void EditReward(RewardDTO rewardDTO);
        RewardDTO GetRewardById(long id);
        void DeleteReward(long id);
        void CreateReward(RewardDTO rewardDTO);
        long GetTotal();
        IEnumerable<RewardDTO> SelectByQuantityItem(int page, int pageSize);
    }
}
