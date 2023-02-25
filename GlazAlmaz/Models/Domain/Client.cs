using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazAlmaz.Models.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string Fullname { get; set; }

        [Required]
        public string Login { get; set; }
        public long Phone { get; set; }
    }
}
