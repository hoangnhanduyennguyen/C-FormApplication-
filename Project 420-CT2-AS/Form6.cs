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
    public partial class Form6 : Form
    {
        IPv4 obj;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            obj = new IPv4();
            lblDate.Text = "Today : " + obj.Today();
        }

        private void btnValIP_Click(object sender, EventArgs e)
        {
            try
            {
                obj.EnIPv4 = txtIpv4.Text.Trim();
                if (obj.Validation() == "correct")
                {
                    MessageBox.Show(obj.EnIPv4 + "\nThe IP is correct", "Valid IP");
                    btnReset.Focus();
                }
                else
                {
                    txtIpv4.Focus();
                    throw new ErrorInvalidIP("The IP must have 4 bytes\ninteger number between 0 to 255" +
                        "\nseparated by a dot (255.255.255.255)");
                }
            }catch (ErrorInvalidIP ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIpv4.Clear();
            txtIpv4.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string dirPath = @".\IPv4\";
            FileStream fs = null;
            string filePath = dirPath + "IPv4Validation.txt";
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                byte count = 0;
                string textToPrint = "Valid IPv4\t\tCurrent Date\n\n";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(',');
                    textToPrint += columns[0] + "\t\t" + columns[1] + "\n";
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

            if(MessageBox.Show("Do you want to quit this application\nIPv4 Validator?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }

    [Serializable]
    internal class ErrorInvalidIP : Exception
    {
        public ErrorInvalidIP()
        {
        }

        public ErrorInvalidIP(string message) : base(message)
        {
        }

        public ErrorInvalidIP(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorInvalidIP(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
