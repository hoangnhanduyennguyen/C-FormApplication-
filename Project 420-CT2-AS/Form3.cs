using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Project_420_CT2_AS
{
    public partial class Form3 : Form
    {
        Boolean reset = false; // check if the whole calculation is done and user want to do another calculation without clicking on clear button
        public Form3()
        {
            InitializeComponent();
        }
        Calculator obj; // Gobal variable
        private void btn_click(object sender, EventArgs e)
        {
            if (txtCal.Text == "0" || reset ||obj.Fini) // if the textbox show 0 or user want to reset the calculator or all the operands are not null
            {
                txtCal.Clear();
                reset = false;
                obj.Fini = false;
            } 
            Button btn = (Button)sender;
            txtCal.Text = txtCal.Text + btn.Text.Substring(1,1); // print the numbers from the buttons without "&"
        }

        private void op_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; 
            obj.CurrentVal = Convert.ToDouble(txtCal.Text); // set the first value for operand1
            obj.Setup(); // set the values for operand1 or operand2
            if (obj.Fini) // check if the two operands are different from 0 
            {
                txtCal.Text = obj.Equals(Convert.ToDouble(txtCal.Text)).ToString(); //pass the value to operand2 and calculate the result
                obj.Op = btn.Text; //set the value for the operation
                reset = true;
            }
            else 
            {
                obj.Op = btn.Text; //if obj.Fini = false, operand2 has not been passed the value so just pass the value of the button to the operation
                txtCal.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCal.Text = "0";
            obj.Clear();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            obj = new Calculator();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string dirPath = @".\Calculator\";
            FileStream fs = null;
            string filePath = dirPath + "Calculator.txt";
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                byte count = 0;
                string textToPrint = "Your calculations\n\n";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    textToPrint += row + "\n";
                    count += 1;
                    if (count == 30)
                    {
                        MessageBox.Show(textToPrint);
                        count = 0;
                        textToPrint = "";
                    }
                }
                if (count != 0)
                {
                    MessageBox.Show(textToPrint, "Hoang Nhan Duyen, Nguyen");
                }
                // close the input stream for the text file
                textIn.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { if (fs != null) fs.Close(); }
            if (MessageBox.Show("Do you want\nto quit the application\nCalculator?",
               "Hoang Nhan Duyen Nguyen", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                txtCal.Focus();
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (!txtCal.Text.Contains(".")) //check if the decimal point already exits
            {
                if (txtCal.Text == "") //if the textbox is empty
                {
                    txtCal.Text = "0" + "."; // 0. will appear in the textbox
                }else
                {
                    txtCal.Text = txtCal.Text + "."; //if the text box has numbers, only add "."
                }
            }else if (reset && txtCal.Text.Contains(".")) // if the previous calculation has been done and the user want to start with 0. but the user doesn't click on 0
            {
                txtCal.Text = "0" + ".";
            }else
            {
                MessageBox.Show("A decimal point has already exited!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);// wrong input message
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtCal.Text = obj.Equals(Convert.ToDouble(txtCal.Text)).ToString(); // do the calculation
            obj.Clear(); //then clear the value of operands and op
            reset = true; // reset to get ready for the new calcultion
        }
    }
}
