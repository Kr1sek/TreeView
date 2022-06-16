using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreeView.Models
{
    [Table("Data")]
    public class DataModel
    {
        [Key]
        public int DataId { get; set; }
        [MaxLength(100)]
        public string DataName { get; set; }
        public int ParentId { get; set; }

        
    }

}
