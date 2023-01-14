using Asignment10.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)==false)
            {
                int grade = int.Parse(textBox1.Text.Trim());
                MessageBox.Show(new MyFunctions().GetGrade(grade));
            }
            else
            {
                MessageBox.Show("لا يمكنك ترك مربع الدرجة فارغا");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = {"حسن","محمد","أحمد","محمود","يوسف"};
            int[] grades = { 45, 55, 75, 85, 95 };
            string[] evaluations = new string[5];
            for (int i = 0; i <names.Count(); i++)
            {
                evaluations[i] = new MyFunctions().GetGrade(grades[i]);
                MessageBox.Show(names[i]+" " + grades[i]+" " + evaluations[i]);
            }
        }
    }
}
