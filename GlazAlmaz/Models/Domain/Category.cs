using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazAlmaz.Models.Domain
{
    public class Category
    {
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
