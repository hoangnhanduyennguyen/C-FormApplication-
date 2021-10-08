using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_420_CT2_AS
{
    class Temperature
    {
        // Private field
        private double enVal;
        private double conVal;
        //Public properties
        public double EnVal
        {
            set { enVal = value; }
            get { return enVal; }
        }
        public double ConVal
        {
            set { conVal = value; }
            get { return conVal; }
        }
        //Constructors
        public Temperature() { }
        public Temperature(double enVal)
        {
            this.enVal = enVal;
        }
        // Methods
        public double TemCon(string choice)
        {
            DateTime curDateTime = DateTime.Now;
            FileStream fs = null;
            string dirPath = @".\Temperature\";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            string filePath = dirPath + "TempConvert.txt";
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            Convert(choice);
            textOut.Write(enVal + " C" + " = ");
            textOut.WriteLine(conVal + " F" + ", " + curDateTime);
            textOut.Close();
            fs.Close();
            return conVal;
        }

        public double Convert(string choice)
        {
            switch (choice)
            {
                case "From C to F":
                    conVal = Math.Round((((enVal * 9) / 5) + 32), 2);
                    break;
                case "From F to C":
                    conVal = Math.Round((((enVal - 32) * 5) / 9), 2);
                    break;
            }
            return conVal;
        }
    }
}

