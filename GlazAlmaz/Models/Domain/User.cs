using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazAlmaz.Models.Domain
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string Login { get; set; }

        [Required, MaxLength(128)]
        public string Password { get; set; }

        [Required]
        public virtual Role Role { get; set; }
    }
}
