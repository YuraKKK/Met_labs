using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table ("tbsFood")]
    public class Kitchener
    {
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Key]
        public Guid Id { get; set; }

        public Specialize Specialize { get; set; }
    }
}
