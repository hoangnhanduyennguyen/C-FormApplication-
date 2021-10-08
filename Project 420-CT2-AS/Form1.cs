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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want \nto quit this application? ", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }else { btnGen.Focus(); }
        }
        Lotto obj; //Global object
        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new Lotto();
        }
        private void btnGen_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine; // Create a new line in multiple text box
            obj.LottoMax("Max");
            string[] arrNum = obj.ArrNum;
            txtResult.Text = arrNum[0];
            for (int i = 1; i <= 6; i++) // For loop to generate and print out the second, third, ... sixth random numbers
            {
                txtResult.Text = txtResult.Text + newLine + arrNum[i]; // Print them with the new line

            }
            txtResult.Text = txtResult.Text + newLine + arrNum[7];
        }

        private void btnReadFl_Click(object sender, EventArgs e)
        {
            string dirPath = @".\Lotto\";
            FileStream fs = null;
            string filePath = dirPath + "LottoNbrs.txt";
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                byte count = 0;
                string textToPrint = "Lotto\tCurrent Date & Time\tNumbers & Bonus\n";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    row = row.Replace("Bonus ", ",");
                    string[] columns = row.Split(';');
                    textToPrint += columns[0] + "\t" + columns[1] + "\t" + columns[2] + columns[3] + "\n";
                    count += 1;
                    if (count == 40)
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

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
