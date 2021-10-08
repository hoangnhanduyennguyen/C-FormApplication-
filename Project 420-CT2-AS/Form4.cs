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
using System.Runtime.Serialization;

namespace Project_420_CT2_AS
{
    public partial class Form4 : Form
    {
        public string inTo = "CAD", inFrom = "CAD", toSign ="C$";
        public Form4()
        {
            InitializeComponent();
        }
        Exchange obj;
        private void Form4_Load(object sender, EventArgs e)
        {
            obj = new Exchange();
        }
   
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nMoney Exchange?",
                "Hoang Nhan Duyen Nguyen", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                txtEnVal.Focus();
            }
        }
        private void From_click(object sender, EventArgs e)
        {
            RadioButton click = (RadioButton)sender;
            inFrom = click.Text;
            txtEnVal.Clear();
            txtConVal.Clear();
        }

        private void To_click(object sender, EventArgs e)
        {
            RadioButton click = (RadioButton)sender;
            inTo = click.Text;
            switch (inTo)
            {
                case "CAD":
                    toSign = "C$";
                    break;
                case "USD":
                    toSign = "$";
                    break;
                case "EUR":
                    toSign = "€";
                    break;
                case "GBP":
                    toSign = "£";
                    break;
                case "VND":
                    toSign = "₫";
                    break;
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (inTo == inFrom)
            {
                MessageBox.Show("Same choice!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (inTo is null)
            {
                MessageBox.Show("Please choose the currency you want to exchange!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Regex reg = new Regex(@"^([0-9]+)([\.]?)([0-9]*)$");
                    if (reg.IsMatch(txtEnVal.Text) == true)
                    {

                        txtConVal.Text = toSign + " " + obj.MonExchange(txtEnVal.Text, inFrom, inTo).ToString();

                    }
                    else
                    {
                        throw new NotAPositiveIntegerOrFloatingPointNumberException("Please enter a positive integer or floating-point number!");
                    }
                }
                catch (NotAPositiveIntegerOrFloatingPointNumberException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void raBtnCAD1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string dirPath = @".\MoneyExchange\";
            FileStream fs = null;
            string filePath = dirPath + "MoneyConversions.txt";
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                byte count = 0;
                string textToPrint = "Money Conversions\t\tCurrent Date & Time\n\n";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    textToPrint += columns[0] + "\t\t" + columns[1] + "\n";
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
                MessageBox.Show(ex.Message, "IOException");
            }
            finally { if (fs != null) fs.Close(); }
        }
    }

    [Serializable]
    internal class NotAPositiveIntegerOrFloatingPointNumberException : Exception
    {
        public NotAPositiveIntegerOrFloatingPointNumberException()
        {
        }

        public NotAPositiveIntegerOrFloatingPointNumberException(string message) : base(message)
        {
        }

        public NotAPositiveIntegerOrFloatingPointNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAPositiveIntegerOrFloatingPointNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
