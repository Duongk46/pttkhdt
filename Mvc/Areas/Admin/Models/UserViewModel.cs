using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Models
{
    public class UserViewModel
    {
        public long ID { set; get; }
        [Display(Name = "Tài khoản")]
        [MaxLength(20,ErrorMessage = "Nhập quá 20 ký tự")]
        [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
        public string Username { set; get; }
        [MaxLength(20, ErrorMessage = "Nhập quá 20 ký tự")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { set; get; }
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string Name { set; get; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { set; get; }
        [Display(Name = "SDT")]
        [Required(ErrorMessage = "Vui lòng nhập SDT")]
        [MinLength(8,ErrorMessage = "Vui lòng nhập ít nhất 8 số")]
        [MaxLength(12,ErrorMessage = "Vui lòng nhập ít hơn 12 số")]
        public string Phone { set; get; }
        [Display(Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string Email { set; get; }
        [Display(Name = "Ngày tạo")]
        [Required(ErrorMessage = "Vui lòng nhập ngày tháng năm sinh")]
        public DateTime CreatedDate { set; get; }
        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        public DateTime BirthDay { set; get; }
        [Display(Name = "Loại user")]
        [Required(ErrorMessage = "Vui lòng chọn loại user")]
        public int? UserType { set; get; }
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Vui lòng chọn loại user")]
        public bool Sex { set; get; }
        public bool Status { set; get; }
    }
}
