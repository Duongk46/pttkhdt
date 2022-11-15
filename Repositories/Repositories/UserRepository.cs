using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.IGenericRepository;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ManageContext _db;
        public UserRepository(ManageContext manageContext) : base(manageContext)
        {
            _db = new ManageContext();
        }
        public int LoginUser(string username,string password)
        {
            var user = _db.Users.SingleOrDefault(x => x.Username == username);
            if (user != null)
            {
                if (user.Password == password)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                return 2;
            }
        }
        public string GetEmailById(long id)
        {
            return _db.Users.SingleOrDefault(u => u.ID == id).Email;
        }
        public long GetIdByUsername(string username)
        {
            var model = _db.Users.SingleOrDefault(u => u.Username == username);
            return model.ID;
        }
        public IEnumerable<User> SelectByQuantityItem(int page,int pageSize)
        {
            try
            {
                var model = _db.Users.Where(x => x.ID != 0).OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _db.Users.Where(x => x.ID != 0).OrderByDescending(x => x.CreatedDate).Count();
        }
        public bool CheckUsername(string username)
        {
            var model = _db.Users.SingleOrDefault(u => u.Username == username);
            return ((model == null) ? true : false);
        }
        public bool CheckEmail(string email)
        {
            var model = _db.Users.SingleOrDefault(u => u.Email == email);
            return ((model == null) ? true : false);
        }
    }
}
