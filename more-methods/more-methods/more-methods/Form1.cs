using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace more_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetColumnName().ToString());
            // MessageBox.Show(GetColumnName().ToString());

            //MessageBox.Show(GetColumnName(6).ToString());

            //string myName = "Idaho State University";
            //Console.WriteLine(myName);

            //string someName = PassByValue(myName);
            //PassByRef(out myName);
            //Console.WriteLine(someName);

            //Console.WriteLine(myName);

            // PassByValue
            //Idaho State University = myName
            //Some other name = someName
            //Idaho State University = myName

            // Idaho State University
            // Some other name

            if (radioButtonBus.Checked)
            {
                MessageBox.Show("You clicked on bus");
            }
            else if(radioBtnBicycle.Checked)
            {
                MessageBox.Show("You clicked on bicyle");
            }
            else
            {
                MessageBox.Show("You didnt clicked on anything");
            }

            MessageBox.Show(getTipAmt(25).ToString());

        }

        private string PassByValue(string name)
        {
            name = "Some other name";
            return name;
        }

        private string PassByRef(out string name)
        {
            name = "Some other name";
            return name;
        }


        private int getcolumnname()
        {
            return 5;
        }

        private int GetColumnName(int num1 = 3)
        {
            return num1;
        }

        private int GetColumnName(int num0, int num1 = 5)
        {
            return num0 + num1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            //MessageBox.Show(trackBar.Value.ToString());
        }

        private double getTipAmt(double billAmt)
        {
            double tipPercent = trackBar.Value;
            return billAmt * (tipPercent / 100); 
        }
    }
}
