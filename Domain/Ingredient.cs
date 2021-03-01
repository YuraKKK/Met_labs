using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Інгредієнти
    /// </summary>
    [Table("tblIngredients")]
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        /// <summary>
        /// Одиниці виміру - грами, штуки...
        /// </summary>
        [Required, StringLength(255)]
        public string Units { get; set; }
    }
}
