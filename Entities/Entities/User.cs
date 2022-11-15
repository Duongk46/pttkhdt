using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Username { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(1024)]
        public string Password { set; get; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(1024)]
        public string Name { set; get; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(1024)]
        public string Address { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Phone { set; get; }
        [Column(TypeName = "varchar")]
        [MaxLength(1024)]
        public string Email { set; get; }
        [Column(TypeName = "datetime2")]
        
        public DateTime CreatedDate { set; get; }
        [Column(TypeName = "datetime2")]
        public DateTime BirthDay { set; get; }
        [Column(TypeName = "smallint")]
        public int? UserType { set; get; }
        public bool Sex { set; get; }
        public bool Status { set; get; }
        public virtual ICollection<Reward> Rewards { set; get; }
        public virtual ICollection<Discipline> Disciplines { set; get; }
        public virtual ICollection<Employee> Employees { set; get; }
        public virtual ICollection<EmployeeSalary> EmployeeSalaries { set; get; }
    }
}
