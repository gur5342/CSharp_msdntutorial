using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msdntutorial_PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (cheStretch.Checked)
                ptbDog.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                ptbDog.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void PtbDog_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            DialogResult result = openFileDialog1.ShowDialog();
            if(result != DialogResult.OK)
            {
                return;
            }
            ptbDog.Load(openFileDialog1.FileName);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Text = $"X = {Location.X}, Y = {Location.Y}";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(cldBackColor.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
