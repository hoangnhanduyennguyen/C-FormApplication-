using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project_420_CT2_AS
{
    class Lotto
    {
        // Private field
        private string[] arrNum;
        //Public properties
        public string[] ArrNum
        {
            set { arrNum = value; }
            get { return arrNum; }
        }
        //Constructors
        public Lotto() { }
        public Lotto(string[] arrNum)
        {
            this.arrNum = arrNum;
        }
        //Methods
        public void LottoMax (string name)
        { 
            FileStream fs = null;
            string dirPath = @".\Lotto\";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            string filePath = dirPath + "LottoNbrs.txt";
            string[] arrNum = new string[8]; // An array to store random numbers generated
            Random random = new Random(); // Create an object of Random class
            DateTime currentDate = DateTime.Now; // Variable to get the current date and time 
            int randomNumber = 0;

            for (int i = 0; i < arrNum.Length; i++) // For loop to generate and print out the random numbers
            {
                repeat:
                randomNumber = random.Next(1, 50); //Generate random numbers
                arrNum[i] = randomNumber.ToString();//Add those numbers to the array
                for (int index = 0; index < i; index++)
                {
                    if (arrNum[index] == arrNum[i])
                    {
                        goto repeat;
                    }
                }
            }
            //Writing the numbers into text file
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write); //Create a file stream object
            StreamWriter textOut = new StreamWriter(fs); // create a stream writer object
            textOut.Write(name +";"+ currentDate.ToString() + ";"); // Write the name of lotto and current date time in the file LottoNbrs.txt
            for (int j = 0; j < arrNum.Length -2; j++)// for loop to write the random numbers for the array in the file LottoNbrs.txt
            {
                textOut.Write(arrNum[j] + ",");
            }
            textOut.Write(arrNum[6] + ";");
            textOut.WriteLine("Bonus " + arrNum[7].ToString()); //write the bonus in the file LottoNbrs.txt
            textOut.Close(); //close the file
            fs.Close(); 
            this.arrNum = arrNum;
        }
        public void Lotto649(string name, int nbr)
        {
            FileStream fs = null;
            string dirPath = @".\Lotto\";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            string filePath = dirPath + "LottoNbrs.txt";
            string[] arrNum = new string[7]; // An array to store random numbers generated
            Random random = new Random(); // Create an object of Random class
            DateTime currentDate = DateTime.Now; // Variable to get the current date and time 
            int randomNumber = 0;

            for (int i = 0; i < arrNum.Length; i++) // For loop to generate and print out the second, third, ... sixth random numbers
            {
                repeat:
                randomNumber = random.Next(1, nbr); //Generate random numbers
                arrNum[i] = randomNumber.ToString();//Add those numbers to the array
                for (int index = 0; index < i; index++)
                {
                    if (arrNum[index] == arrNum[i])
                    {
                        goto repeat;
                    }
                }
            }
            //Writing the numbers into text file
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write); //Create a file stream object
            StreamWriter textOut = new StreamWriter(fs); // create a stream writer object
            textOut.Write(name + ";" + currentDate.ToString() + ";"); // Write the name of lotto and current date time in the file LottoNbrs.txt
            for (int j = 0; j < arrNum.Length - 2; j++)// for loop to write the random numbers for the array in the file LottoNbrs.txt
            {
                textOut.Write(arrNum[j] + ",");
            }
            textOut.Write(arrNum[5] + ";");
            textOut.WriteLine("Bonus " + arrNum[6].ToString()); //write the bonus in the file LottoNbrs.txt
            textOut.Close(); //close the file
            fs.Close();
            this.arrNum = arrNum;
        }
    }
}
