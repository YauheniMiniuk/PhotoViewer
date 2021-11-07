using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Открыть изображение";
            ofd.Filter = ".jpg files(*.jpg)|*.jpg|.png files(*.png)|*.png|All files(*.*)|*.*";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
