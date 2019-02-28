using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven.Models
{
   public class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name ="Create")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => Title;
        
            
        
    }
}
