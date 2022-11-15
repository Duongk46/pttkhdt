using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserBusiness
    {
        int CheckLogin(string username, string password);
        bool DeleteUser(long id);
        bool EditUser(UserDTO userDTO);
        int CreateUser(UserDTO userDTO);
        UserDTO getUserDTOById(long id);
        long GetTotal();
        IEnumerable<UserDTO> SelectByQuantityItem(int page, int pageSize);
        IEnumerable<UserDTO> SelectAllUsers();
    }
}
