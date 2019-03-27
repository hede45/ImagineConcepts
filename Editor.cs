using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Domain.Entities
{
    public class Editor 
    {
        [Key]
        public int EditorId { get; set; }

        [ForeignKey("Architect")]
        public int ArchitectId { get; set; }

        public virtual Architect Architect { get; set; }
    }
}
