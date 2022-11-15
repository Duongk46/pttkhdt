using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Models
{
    public class RewardViewModel
    {
        public long ID { set; get; }
        [Display(Name = "Tên giải thưởng")]
        [Required(ErrorMessage = "Vui lòng nhập tên giải thưởng")]
        public string NameReward { set; get; }
        [StringLength(255)]
        [Required(ErrorMessage = "Vui lòng chọn tên nhân viên")]
        [Display(Name = "Tên người nhận")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Vui lòng điền giá tiền")]
        [Display(Name = "Tiền")]
        public long Money { set; get; }
        [Display(Name = "ID người tạo")]
        public long? CreatedBy { set; get; }
        public DateTime CreatedDate { set; get; }
        [Display(Name = "Trạng thái")]
        public bool Status { set; get; }
        public long IDEmployee { set; get; }
    }
}
