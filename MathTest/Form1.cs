using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTest
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        private int add1, add2, res1, res2, mul1, mul2, div1, div2;

        private void startbtn_Click(object sender, EventArgs e)
        {
            startQuiz();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {

        }

        private void startQuiz()
        {
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);
            sumLeft.Text=add1.ToString();
            sumRight.Text = add2.ToString();




            sumResult.Value = 0;
        }

    }
}
