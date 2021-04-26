using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public abstract class BaseKitchener
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Specialize Specialize { get; set; }
        protected List<BaseFood> _foods;
        public BaseKitchener()
        {
            _foods = new List<BaseFood>();
        }
    }
}
