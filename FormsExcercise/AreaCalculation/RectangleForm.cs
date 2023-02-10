using AreaCalculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateArea
{
    public partial class RectangleForm : Form
    {
        float area;

        public RectangleForm()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            area = float.Parse(heightTxt.Text) * float.Parse(widthTxt.Text);

            resultsLbl.Text = "The Area of this rectangle is: " + area.ToString();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
        }
    }
}
