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
    public partial class CircleForm : Form
    {
        double area;

        public CircleForm()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if(isRadiusChk.Checked)
            {
                area = Math.PI * float.Parse(valueTxt.Text) * float.Parse(valueTxt.Text);

                resultsLbl.Text = "The area of this Circle is: " + area.ToString();
            }
            else
            {
                float radius = float.Parse(valueTxt.Text) /2;
                area = Math.PI * radius * radius;

                resultsLbl.Text = "The area of this Circle is: " + area.ToString();
            }
        }
    }
}
