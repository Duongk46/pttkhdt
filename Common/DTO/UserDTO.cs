using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class UserDTO
    {
        public long ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime BirthDay { set; get; }
        public int? UserType { set; get; }
        public bool Sex { set; get; }
        public bool Status { set; get; }
    }
}
