using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class EmployeeDTO
    {
        public long ID { set; get; }
        public string Name { set; get; }
        public DateTime BirthDay { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public DateTime CreatedDate { set; get; }
        public bool Sex { set; get; }
        public int Type { set; get; }
        public bool Status { set; get; }
        public long? CreatedBy { set; get; }
    }
}
