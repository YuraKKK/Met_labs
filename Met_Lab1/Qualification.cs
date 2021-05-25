using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class QualificationFood
    {
        private Guid _id { get; set; }
        private Food _food;
        private int _qualificationTime { get; set; }
        public QualificationFood(Food food, int qualificationTime)
        {
            _id = Guid.NewGuid();
            _food = food;
            _qualificationTime = qualificationTime;
        }
        public int QualificationTime { get { return _qualificationTime; } }
    }
    public class Qualification
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private List<QualificationFood> _qualificationFoods { get; set; }
        public Qualification(string name, List<QualificationFood> qualificationFoods)
        {
            _id = Guid.NewGuid();
            _name = name;
            _qualificationFoods = qualificationFoods;
        }
        public List<QualificationFood> GetQualificationFoods()
        {
            return _qualificationFoods;
        }
    }
}
