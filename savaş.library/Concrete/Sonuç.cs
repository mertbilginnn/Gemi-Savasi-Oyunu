using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemi_Savaşı
{
    public partial class Sonuç : Form
    {
        public Sonuç()
        {

            InitializeComponent();
            string readText = File.ReadAllText("Test.txt");
            string[] points = readText.Split(' ');
            richTextBox1.Text = "1. Point: " + points[0] + "\n2.Point: " + points[2] + "\n3.Point: " + points[4] + "\n4.Point: " + points[6] + "\n5.Point: " + points[8];
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
