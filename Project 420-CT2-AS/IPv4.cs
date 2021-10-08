using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Project_420_CT2_AS
{
    class IPv4
    {
        // Private field
        private string enIPv4;
        //Public properties
        public string EnIPv4
        {
            set { enIPv4 = value; }
            get { return enIPv4; }
        }
        //Constructors
        public IPv4() { }
        
        //Methods
        public string Today()
        {
            DateTime currDate = DateTime.Today;
            string date = currDate.ToLongDateString();
            return date;
        }
        public string Validation()
        {
            string date = Today();
            string val = "incorrect";
            FileStream fs = null;
            string dirPath = @".\IPv4\";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            string filePath = dirPath + "IPv4Validation.txt";
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write); //Create a file stream object
            StreamWriter textOut = new StreamWriter(fs); // create a stream writer object
            Regex ipRe = new Regex(@"^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|00[1-9]|0[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|00[1-9]|0[0-9][0-9]|[1-9][0-9]|[0-9])$");
            if (ipRe.IsMatch(EnIPv4))
            {
                val = "correct";
                textOut.WriteLine(EnIPv4 + ',' + date);
            }
            textOut.Close(); //close the file
            fs.Close();
            return val;
        }


    }
}
