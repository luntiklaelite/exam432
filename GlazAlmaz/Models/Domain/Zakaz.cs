using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazAlmaz.Models.Domain
{
    public class Zakaz
    {
        [Key, MaxLength(128)]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(128)]
        public string Description { get; set; }

        [Required]
        public virtual Client Client { get; set; }

        [Required]
        public virtual Tovar Tovar { get; set; }
    }
}
