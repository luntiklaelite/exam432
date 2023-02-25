using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazAlmaz.Models.Domain
{
    public class Tovar
    {
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; }

        [Required, MaxLength(128)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [MaxLength(128)]
        public string PictureFileName { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Postavshik Postavshik { get; set; }

    }
}
