using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapThree
{
    public partial class Form1 : Form
    {
        //Create Vars in Here!
        int Num = 23;
        double DbNum = 9.0;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //int Result = Num;
            //MessageBox.Show("The Number Stored in The Var is " + Result.ToString());
            //MessageBox.Show("");

            //2 Var -> ADD, SUBS, MULTI, DIV
            //RESULT MESSAGE

            //Change Colors when button is clicked
            //1. Directly => name + . + propertyName = property value;
            lblChangedColorText.ForeColor = Color.Red;

            //Abdiqaadir Ibrahim
            //lblChangedColorText.Text = ''

            //Abdimajid 
            //lblChangedColorText.Text = Color("Abdimajid") == Mistake


        }
    }
}
