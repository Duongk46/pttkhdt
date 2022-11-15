using AutoMapper;
using Business.Interfaces;
using Business.Tool;
using Common.DTO;
using Entities.Entities;
using Repositories.IGenericRepository;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<User> _genericRepository;
        public UserBusiness(IUserRepository userRepository,IMapper mapper,IGenericRepository<User> genericRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _genericRepository = genericRepository;
        }
        public int CheckLogin(string username,string password)
        {
            var check = _userRepository.LoginUser(username, password);
            return check;
        }
        public bool DeleteUser(long id)
        {
            _userRepository.Delete(id);
            _userRepository.Save();
            return true;
        }
        public IEnumerable<UserDTO> SelectAllUsers()
        {
            var users = _userRepository.SelectAll();
            var userDtos = users.Select(item => _mapper.Map<User,UserDTO>(item));
            return userDtos;
        }
        public IEnumerable<UserDTO> SelectByQuantityItem(int page,int pageSize)
        {
            var users = _userRepository.SelectByQuantityItem(page, pageSize);
            var userDtos = users.Select(item => _mapper.Map<User, UserDTO>(item));
            return userDtos;
        }
        public long GetTotal()
        {
            return _userRepository.GetTotal();
        }
        public UserDTO getUserDTOById(long id)
        {
            var user = _userRepository.SelectById(id);
            var userDto = new UserDTO();
            userDto = _mapper.Map<User, UserDTO>(user);
            return userDto;
        }
        public int CreateUser(UserDTO userDTO)
        {
            var user = new User();
            userDTO.CreatedDate = DateTime.Now;
            userDTO.Status = true;
            if (_userRepository.CheckUsername(userDTO.Username))
            {
                if (_userRepository.CheckEmail(userDTO.Email))
                {
                    user = _mapper.Map<UserDTO, User>(userDTO);
                    _userRepository.Insert(user);
                    _userRepository.Save();
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            else return 2;
        }
        public bool EditUser(UserDTO userDTO)
        {
            var user = new User();
            userDTO.CreatedDate = DateTime.Now;
            userDTO.Status = true;
            var Email = _userRepository.GetEmailById(userDTO.ID);
            if (_userRepository.CheckEmail(userDTO.Email) || Email == userDTO.Email)
            {
                user = _mapper.Map<UserDTO, User>(userDTO);
                _userRepository.Update(user);
                _userRepository.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
