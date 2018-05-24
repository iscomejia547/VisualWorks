using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PairGame
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        private Label first=null;
        private Label second=null;
        public Form1()
        {
            InitializeComponent();
            loadIcons();
        }
        private void loadIcons()
        {
            foreach (Control item in GameTab.Controls)
            {
                Label lbl = item as Label;
                if (lbl != null)
                {
                    int num = rnd.Next(icons.Count);
                    lbl.Text = icons[num];
                    lbl.ForeColor = lbl.BackColor;
                    icons.RemoveAt(num);
                }
            }
        }

        private void label_clicked(object sender, EventArgs e)
        {
            if (defTimer.Enabled) return;
            Label clicked = sender as Label;
            if (clicked != null)
            {
                if (clicked.ForeColor == Color.Black) return;
                if (first==null)
                {
                    first = clicked;
                    first.ForeColor = Color.Black;
                    return;
                }
                second = clicked;
                second.ForeColor = Color.Black;

                checke();

                if (first.Text.Equals(second.Text))
                {
                    first = null;
                    second = null;
                    return;
                }
                defTimer.Start();
            }
        }

        private void defTimer_Tick(object sender, EventArgs e)
        {
            defTimer.Stop();
            first.ForeColor = first.BackColor;
            second.ForeColor = second.BackColor;

            first = null;
            second = null;
        }
        private void checke()
        {
            foreach (Control item in GameTab.Controls)
            {
                Label temp=item as Label;
                if (temp != null)
                {
                    if (temp.ForeColor == Color.Black)
                    {
                        return;
                    }
                }
                MessageBox.Show("Felicidades!\nHa Ganado", "", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                if(MessageBox.Show("Desea jugar nuevamente?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    loadIcons();
                }
                else
                {
                    this.Close();
                }
            }
            
        }
    }
}
