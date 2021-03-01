using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Kitchener
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Specialize Specialize { get; set; }
    }
}
