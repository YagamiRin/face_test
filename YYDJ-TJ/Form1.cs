using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace YYDJ_TJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FaceRec FaceRec = new FaceRec();

        private void button1_Click(object sender, EventArgs e)
        {
            FaceRec.openCamera(pictureBox1,pictureBox2);
        }
    }
}
