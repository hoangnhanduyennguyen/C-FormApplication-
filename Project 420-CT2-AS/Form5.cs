using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Project_420_CT2_AS
{
    public partial class Form5 : Form
    {
        string choice = "C to F";
        Temperature obj;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            obj = new Temperature();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double enVal;
                txtMess.Clear();
                Regex reg = new Regex(@"^[\-]?[0-9]+[\.]?[0-9]*$");
                if (reg.IsMatch(txtFrom.Text) == true)
                {
                    enVal = Convert.ToDouble(txtFrom.Text.Trim());
                    obj.EnVal = enVal;
                    txtTo.Text = obj.TemCon(choice).ToString();
                    if ((enVal == 100 && choice =="From C to F") || (enVal == 212 && choice == "From F to C"))
                    {
                        txtMess.Text = "Water boils";
                        txtMess.ForeColor = Color.Red;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if ((enVal == 40 && choice == "From C to F")|| (enVal == 104 && choice == "From F to C"))
                    {
                        txtMess.Text = "Hot Bath";
                        txtMess.ForeColor = Color.Red;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if ((enVal == 37 && choice == "From C to F") || (enVal == 98.6 && choice == "From F to C"))
                    {
                        txtMess.Text = "Body temperature";
                        txtMess.ForeColor = Color.DarkGreen;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if ((enVal == 30 && choice == "From C to F")|| (enVal == 86 && choice == "From F to C"))
                    {
                        txtMess.Text = "Beach weather";
                        txtMess.ForeColor = Color.DarkGreen;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if (((Math.Abs(enVal - 21) <= 0.01) && choice == "From C to F") || ((Math.Abs(enVal - 70) <= 0.01) && choice == "From F to C"))
                    {
                        txtMess.Text = "Room temperature";
                        txtMess.ForeColor = Color.DarkGreen;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if ((enVal == 10 && choice == "From C to F") || (enVal == 50 && choice == "From F to C"))
                    {
                        txtMess.Text = "Cool Day";
                        txtMess.ForeColor = Color.CornflowerBlue;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if ((enVal == 0 && choice == "From C to F")|| (enVal == 32 && choice == "From F to C"))
                    {
                        txtMess.Text = "Freezing point of water";
                        txtMess.ForeColor = Color.CornflowerBlue;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if (((Math.Abs(enVal - (-18)) <= 0.01) && choice == "From C to F") || ((Math.Abs(enVal - 0) <= 0.01) && choice == "From F to C"))
                    {
                        txtMess.Text = "Very Cold Day";
                        txtMess.ForeColor = Color.CornflowerBlue;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                    if (enVal == -40)
                    {
                        txtMess.Text = "Extremly Cold Day" + Environment.NewLine + "(and the same number!)";
                        txtMess.ForeColor = Color.CornflowerBlue;
                        txtMess.BackColor = txtMess.BackColor;
                    }
                }
                else
                {
                    throw new NotAnIntegerOrFloatingPointNumberException("Please enter an integer or floating point number!");
                }
            }
            catch (NotAnIntegerOrFloatingPointNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string dirPath = @".\Temperature\";
            FileStream fs = null;
            string filePath = dirPath + "TempConvert.txt";
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                byte count = 0;
                string textToPrint = "Money Conversions\tDate & Time\n\n";
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    textToPrint += columns[0] + "\t\t" + columns[1] + "\n";
                    count += 1;
                    if (count == 20)
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
                textIn.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally { if (fs != null) fs.Close(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit this application \nTemperature Conversion?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void raBtnCF_Click(object sender, EventArgs e)
        {
            leftLable.Text = "C";
            rightLable.Text = "F";
            RadioButton btn = (RadioButton)sender;
            choice = btn.Text.Trim();
        }

        private void raBtnFC_Click(object sender, EventArgs e)
        {
            leftLable.Text = "F";
            rightLable.Text = "C";
            RadioButton btn = (RadioButton)sender;
            choice = btn.Text.Trim();
        }
    }

    [Serializable]
    internal class NotAnIntegerOrFloatingPointNumberException : Exception
    {
        public NotAnIntegerOrFloatingPointNumberException()
        {
        }

        public NotAnIntegerOrFloatingPointNumberException(string message) : base(message)
        {
        }

        public NotAnIntegerOrFloatingPointNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAnIntegerOrFloatingPointNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
