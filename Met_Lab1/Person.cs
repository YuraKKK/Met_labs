using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
    }
}
