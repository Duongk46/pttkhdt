using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Models
{
    public class EmployeeSalaryViewModel
    {
        public long ID { set; get; }
        [Display(Name = "Họ và tên")]
        public string Name { set; get; }
        [Display(Name = "Ngày tạo")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { set; get; }
        [Required(ErrorMessage = "Vui lòng nhập tiền lương")]
        [Display(Name = "Tiền lương")]
        public long Salary { set; get; }
        [Display(Name = "Tổng tiền")]
        public long Total { set; get; }
        public bool Status { set; get; }
        public long? CreatedBy { set; get; }
        [Display(Name = "Tên")]
        public long? IDEmployee { set; get; }
    }
}
