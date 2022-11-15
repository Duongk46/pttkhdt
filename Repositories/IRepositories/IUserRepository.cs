using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface IUserRepository
    {
        int LoginUser(string username, string password);
        string GetEmailById(long id);
        long GetIdByUsername(string username);
        bool CheckUsername(string username);
        bool CheckEmail(string email);
        long GetTotal();
        IEnumerable<User> SelectByQuantityItem(int page, int pageSize);
        IEnumerable<User> SelectAll();
        User SelectById(object id);
        void Insert(User obj);
        Task Update(User obj);
        void Delete(object id);
        void DeleteByItem(User id);
        void Save();
    }
}
