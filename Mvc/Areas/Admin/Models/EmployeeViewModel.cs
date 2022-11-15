using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Models
{
    public class EmployeeViewModel
    {
        public long ID { set; get; }
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập tên nhân viên")]
        
        public string Name { set; get; }
        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        public DateTime BirthDay { set; get; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { set; get; }
        [Display(Name = "SDT")]
        [Required(ErrorMessage = "Vui lòng nhập SDT")]
        public string Phone { set; get; }
        [Display(Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string Email { set; get; }
        [Display(Name = "Ngày làm")]
        public DateTime CreatedDate { set; get; }
        [Display(Name = "Loại chức vụ")]
        [Required(ErrorMessage = "Vui lòng chọn loại chức vụ")]
        public string Type { set; get; }
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public bool Sex { set; get; }
        [Display(Name = "Người tạo")]
        public long? CreatedBy { set; get; }
        public bool Status { set; get; }
    }
}
