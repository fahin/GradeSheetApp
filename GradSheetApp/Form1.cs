using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradSheetApp
{
    public partial class GradeSheetForm : Form
    {
        public GradeSheetForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            GradeSheet grade = new GradeSheet();
            grade.Physics = Convert.ToDouble(physicsTextBox.Text);
            grade.Chemistry = Convert.ToDouble(chemistryTextBox.Text);
            grade.Math = Convert.ToDouble(mathTextBox.Text);

            grade.averageCalculation();
            averageTextBox.Text = Convert.ToString(grade.Average);
           grade.gradeCalculation();
           gradeTextBox.Text = grade.Grade;


        }
    }
}
