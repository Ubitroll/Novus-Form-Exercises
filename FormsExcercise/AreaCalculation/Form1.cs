using CalculateArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RectangleForm rect = new RectangleForm();
            rect.Show();
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CircleForm circle = new CircleForm();
            circle.Show();
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TriangleForm tri = new TriangleForm();
            tri.Show();
        }
    }
}
