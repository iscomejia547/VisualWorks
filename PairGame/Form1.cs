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
            Label clicked = sender as Label;
            if (clicked != null)
            {
                if (clicked.ForeColor == Color.Black) return;
                clicked.ForeColor = Color.Black;
            }
        }
    }
}
