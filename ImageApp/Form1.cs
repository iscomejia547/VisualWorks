using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PicMain.Image = null;
        }

        private void StretchCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (StretchCHB.Checked)
            {
                PicMain.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PicMain.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void bkgBtn_Click(object sender, EventArgs e)
        {
            if (colorSet.ShowDialog() == DialogResult.OK)
            {
                PicMain.BackColor = colorSet.Color;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if(openDlg.ShowDialog()==DialogResult.OK){
                PicMain.Load(openDlg.FileName);
            }
        }
    }
}
