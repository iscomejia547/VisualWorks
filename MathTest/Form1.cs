﻿using System;
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
        private int add1, add2, res1, res2, mul1, mul2, div1, div2, time;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (checke())
            {
                timer.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startbtn.Enabled = true;
            }
            else if (time > 0)
            {
                time -= 1;
                timelabel.Text = time + " seconds";
            }
            else
            {
                timer.Stop();
                timelabel.Text = "Time's up";
                MessageBox.Show("No terminaste a tiempo");
                sumResult.Value = add1 + add2;
                startbtn.Enabled = true;
            }
        }

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
            time = 30;
            timelabel.Text = "30 seconds";
            timer.Start();
            startbtn.Enabled = false;
        }
        private bool checke()
        {
            if (sumResult.Value == add1 + add2) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
