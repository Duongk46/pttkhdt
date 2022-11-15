using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class EmployeeSalaryDTO
    {
        public long ID { set; get; }
        public DateTime CreatedDate { set; get; }
        public long Salary { set; get; }
        public long? CreatedBy { set; get; }
        public bool Status { set; get; }
        public long? IDEmployee { set; get; }
    }
}
