using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Їжа
    /// </summary>
    [Table ("tbsFood")]
    public class Food
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public Specialize Specialize { get; set; }
        public int Weight { get; set; }
        public int Time { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
