using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_420_CT2_AS
{
    class Exchange
    {
        private double enteredVal;
        public double EnteredVal
        {
            set { enteredVal = value; }
            get { return enteredVal; }
        }
        public Exchange() { }

        double from, to, outVal;

        public double MonExchange(string enVal, string inFrom, string inTo)
        {
            from = Value(inFrom);
            to = Value(inTo);
            DateTime currentDate = DateTime.Now; // Variable to get the current date and time 
            FileStream fs = null;
            string dirPath = @".\MoneyExchange\";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            string filePath = dirPath + "MoneyConversions.txt";
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write); //Create a file stream object
            StreamWriter textOut = new StreamWriter(fs); // create a stream writer object
            textOut.Write(enVal + " " + inFrom + "=");
            outVal = Math.Round((Convert.ToDouble(enVal) * (to / from)), 2);
            textOut.Write(outVal + " " + inTo + ",  ");
            textOut.WriteLine(currentDate);
            textOut.Close(); //close the file
            fs.Close();
            return outVal;
        }

        private double Value(string enCur)
        {
            double value = 0;
            switch (enCur)
            {
                case "CAD":
                    value = 1;
                    break;

                case "USD":
                    value = 0.7;
                    break;
                case "EUR":
                    value = 0.65;
                    break;
                case "GBP":
                    value = 0.6;
                    break;
                case "VND":
                    value = 16180.35;
                    break;
            }

            return value;
        }

    }
}
