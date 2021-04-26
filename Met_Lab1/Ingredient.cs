using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    /// <summary>
    /// Інгредієнти
    /// </summary>
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Одиниці виміру - грами, штуки...
        /// </summary>
        public string Units { get; set; }
    }
}
