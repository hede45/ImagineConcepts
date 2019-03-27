using Arch.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Domain.Entities
{
    public class File
    {
        public File()
        {
            //Editors = new List<Editor>();
            DateUploaded = UgandaDateTime.DateNow();
        }

        [Key]
        public int FileId { get; set; }

        [StringLength(80)]
        public string FileTitle { get; set; }
        public DateTime DateUploaded { get; set; }
        public DateTime? Updated { get; set; }

        //[ForeignKey("User")]
        //public int EditorId { get; set; }

        public virtual ICollection<Editor> Editors { get; set; }
        //public virtual ApplicationUser User { get; set; }

        //Methods
        public void Update()
        {
            Updated = UgandaDateTime.DateNow();
        }
    }
}
