using AutoMapper;
using Business.Interfaces;
using Common.DTO;
using Entities.Entities;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements
{
    public class RewardBusiness : IRewardBusiness
    {
        private readonly IRewardRepository _rewardRepository;
        private readonly IMapper _mapper;
        public RewardBusiness(IRewardRepository rewardRepository,IMapper mapper)
        {
            _rewardRepository = rewardRepository;
            _mapper = mapper;
        }
        public IEnumerable<RewardDTO> SelectAll()
        {
            var rewards = _rewardRepository.SelectAllByStatus();
            var rewardDtos = rewards.Select(item => _mapper.Map<Reward, RewardDTO>(item));
            return rewardDtos;
        }
        public void EditReward(RewardDTO rewardDTO)
        {
            var Reward = new Reward();
            Reward = _mapper.Map<RewardDTO, Reward>(rewardDTO);
            _rewardRepository.Update(Reward);
            _rewardRepository.Save();
        }
        public RewardDTO GetRewardById(long id)
        {
            var Reward = _rewardRepository.SelectById(id); ;
            var RewardDto = _mapper.Map<Reward, RewardDTO>(Reward);
            return RewardDto;
        }
        public void DeleteReward(long id)
        {
            _rewardRepository.Delete(id);
            _rewardRepository.Save();
        }
        public void CreateReward(RewardDTO rewardDTO)
        {
            rewardDTO.CreatedDate = DateTime.Now;
            var reward = _mapper.Map<RewardDTO, Reward>(rewardDTO);
            _rewardRepository.Insert(reward);
            _rewardRepository.Save();
        }
        public IEnumerable<RewardDTO> SelectByQuantityItem(int page,int pageSize)
        {
            var rewards = _rewardRepository.SelectByQuantityItem(page, pageSize);
            var rewardDtos = rewards.Select(item => _mapper.Map<Reward, RewardDTO>(item));
            return rewardDtos;
        }
        public long GetTotal()
        {
            return _rewardRepository.GetTotal();
        }
    }
}
