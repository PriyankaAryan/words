using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Dictionary")]
    public class Word
    {
        public int WordId { get; set; }
        public string WordName { get; set; }

    }
}
