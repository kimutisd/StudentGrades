namespace StudentsGrades
{
    using System;
    using System.Windows.Forms;
    using DomainObject;

    public partial class Form1 : Form
    {
        private decimal _grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatedGrade.Text = GradesAgent.GetGrade(_grade, DateTime.Now);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(gradeInput.Text, out _grade);
        }
    }
}