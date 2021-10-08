using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_420_CT2_AS
{
    class Calculator
    {
        //Private field
        private double currentVal = 0, operand1 = 0, operand2 = 0;
        private string op = "";
        private Boolean fini = false;
        //Constructor
        public Calculator() { }
        // Property
        public double CurrentVal
        {
            set { currentVal = value; }
            get { return currentVal; }
        }
        public double Operand2
        {
            set { operand2 = value; }
            get { return operand2; }
        }
        public Boolean Fini
        {
            set { fini = value; }
            get { return fini; }
        }
        public string Op
        {
            set { op = value; }
            get { return op; }
        }
        //Method
        public void Setup() // decide where the value should be passed on
        {
            if (operand1 == 0)
            {
                operand1 = CurrentVal;
                operand2 = 0;
            }
            else
            {
                operand2 = CurrentVal;
            }
            if (operand1 != 0 || operand2 != 0)
            {
                Fini = true;
            }
            
        }
        public double Equals(double displayVal)
        {
            operand2 = displayVal; // pass the value to operand2
            if (operand1 != operand2 && op != "")
            {
                FileStream fs = null;
                string dirPath = @".\Calculator\";
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);
                string filePath = dirPath + "Calculator.txt";
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs); // create a stream writer object
                textOut.Write(" " + operand1.ToString() + "  "); //write the value of operand1 before the calculation 

                switch (op)
                {
                    case "+":
                        operand1 = operand1 + operand2;
                        break;
                    case "-":
                        operand1 = operand1 - operand2;
                        break;
                    case "*":
                        operand1 = operand1 * operand2;
                        break;
                    case "/":
                        operand1 = operand1 / operand2;
                        break;
                }
                textOut.WriteLine(op.ToString() + "  " + operand2.ToString() + " = " + operand1.ToString() + ";"); //write the others of the calculation 
                textOut.Close(); //close the file
                fs.Close();
            }
            return operand1; 
        }
        public void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            currentVal = 0;
            op = "";
        }
    }
}
