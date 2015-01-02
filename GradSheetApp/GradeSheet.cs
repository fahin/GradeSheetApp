using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradSheetApp
{
    class GradeSheet
    {
        private double physics;

        public double Physics
        {
            get { return physics; }
            set { physics = value; }
        }
        private double chemistry;

        public double Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }
        private double math;

        public double Math
        {
            get { return math; }
            set { math = value; }
        }
        private double average;

        public double Average
        {
            get { return average; }
            set { average = value; }
        }
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }


        public void averageCalculation()
        {
            average = (physics + chemistry + math) / 3;
        
        }
        public void gradeCalculation()
        {

            if (average>=80)
            {
                grade = "A+";

            }
            if (average >= 70 && average < 80)
            {
                grade = "B+";
            }
            if (average >= 60 && average < 70)
            {
                grade = "C+";
            }
            if (average >= 50 && average < 60)
            {
                grade = "D+";
            }
            if(average<50)
            {
                grade = "F";
            }
        }
    }
}
