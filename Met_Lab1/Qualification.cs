using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class QualificationFood
    {
        public Guid Id { get; set; }
        public Food food;
        public int QualificationTime { get; set; }
    }
    public class Qualification
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<QualificationFood> qualificationFoods { get; set; }
    }
}
