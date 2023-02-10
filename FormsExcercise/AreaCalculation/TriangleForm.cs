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
    public partial class TriangleForm : Form
    {
        double area;

        public TriangleForm()
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
            try
            {
                float s = (float.Parse(lengthATxt.Text) + float.Parse(lengthBTxt.Text) + float.Parse(lengthCTxt.Text)) / 2;

                float sArea = (s * (s - float.Parse(lengthATxt.Text)) * (s - float.Parse(lengthBTxt.Text)) * (s - float.Parse(lengthCTxt.Text)));

                if (sArea <= 0)
                {
                    resultsLbl.Text = "Impossible Triangle";
                }
                else
                {
                    area = Math.Sqrt(sArea);
                    resultsLbl.Text = "The Area of the Triangle is: " + area.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
                
            }           
        }
    }
}
