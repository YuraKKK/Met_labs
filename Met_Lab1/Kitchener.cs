using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Kitchener
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private Qualification _qualification;
        private Specialize _specialize;
        public Kitchener(string name, Qualification qualification, Specialize specialize)
        {
            _id = Guid.NewGuid();
            _name = name;
            _qualification = qualification;
            _specialize = specialize;
        }
        public int TimeCooking()
        {
            int time = 0;
            foreach (var food in _qualification.GetQualificationFoods())
            {
                time += food.QualificationTime;
            }
            return time;
            
        }
    }
}