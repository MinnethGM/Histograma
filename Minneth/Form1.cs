using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Minneth
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _InputImage;
        Image<Gray, byte> _GrayImage;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Filename = "c:\\lenna.jpg";
            _InputImage = new Image<Bgr, byte>(Filename);

            if (_InputImage == null)
            {
                MessageBox.Show("Imagen no cargada");
                return;
            }

            imageBox1.Image = _InputImage;

        }
    }
}
