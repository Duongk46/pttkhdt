using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Discipline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { set; get; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(1024)]
        public string Name { set; get; }
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { set; get; }
        public long Money { set; get; }
        public bool Status { set; get; }
        public long? IDEmployee { set; get; }
        public long? CreatedBy { set; get; }
        [ForeignKey("CreatedBy")]
        public virtual User User { set; get; }
        [ForeignKey("IDEmployee")]
        public virtual Employee Employee { set; get; }
    }
}
