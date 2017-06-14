using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIntegerExam
{
    public class BigInteger
    {
        // poleta
        private string firstNumber;
        private string secondNumber;
        private string result = "";

        // konstruktor defaut
        public BigInteger()
            : this("0", "0")
        {

        }
        // construktor with parameters
        public BigInteger(string fNum, string sNum)
        {
            this.FirstNumber = RevereResult(fNum);
            this.SecondNumber =RevereResult(sNum);
        }

        public string FirstNumber
        {
            get
            {
                return this.firstNumber;
            }
            set
            {
                 this.firstNumber = value;
            }
        }
        public string SecondNumber
        {
            get
            {
                return this.secondNumber;
            }
            set
            {
                this.secondNumber = value;
            }
        }


        public void EqualsLenght()
        {
            if (this.FirstNumber.Length < this.SecondNumber.Length)
            {
                this.FirstNumber = LengthEqualization(this.FirstNumber, this.SecondNumber);
            }
            else if(this.FirstNumber.Length > this.SecondNumber.Length)
            {
                this.SecondNumber = LengthEqualization(this.SecondNumber, this.FirstNumber);
            }
            


        }
        public  string Addition()
        {
            EqualsLenght();
            int oneOnMind = 0;
            for (int i = 0; i < this.SecondNumber.Length; i++)
            {                
                int a = ConvetChar(this.FirstNumber[i].ToString());
                if (oneOnMind == 1)
                {
                    a += oneOnMind;
                }
                int b = ConvetChar(this.SecondNumber[i].ToString());
                int middleResult = a + b;
                oneOnMind = 0;
                if (middleResult > 9)
                {
                    string index = middleResult.ToString();
                    this.result += index[1];
                    oneOnMind = Convert.ToInt32(index[0]);
                }
                this.result += middleResult;
                
            }
            return RevereResult(this.result);
        }

        public string Substraction()
        {
            EqualsLenght();
            int oneOnminde = 0;
            for (int i = 0; i < this.SecondNumber.Length; i++)
            {
                int a = ConvetChar(this.FirstNumber[i].ToString());
                if (oneOnminde != 0 )
                {
                    a -= 1;
                }
                int b = ConvetChar(this.SecondNumber[i].ToString());
                if (a < b)
                {
                    a += 10;
                    oneOnminde = 1;
                }
                int middleResult = a - b;
                this.result += middleResult;

            }
            return RevereResult(this.result);

            
        }

        public string MyultiplicationAciton(string first, string second)
        {
            List<string> list = new List<string>();
            first = RevereResult(first);
            long b = long.Parse(first);
              for (int j = 0; j < second.Length; j++)
                {
                    long a = int.Parse(second[j].ToString());
                    string middleresult = Convert.ToString(a * b);
                    if (j > 0)
                    {
                        middleresult += 0;
                    }
                    list.Add(middleresult);
                }
            
            return this.result =  SumList(list);
        }
        private string SumList(List<string> list)
        {
            
            
            for (int i = 0; i < list.Count; i++)
            {
                this.FirstNumber = RevereResult(this.result);
                this.SecondNumber =RevereResult(list[i]);              
                this.result = Adiiton_myultiplication_numbers() ;
            }
            return this.result;
        }
        public string Myultiplication()
        {
            if (this.FirstNumber.Length < this.SecondNumber.Length)
            {
                return MyultiplicationAciton(this.FirstNumber, this.SecondNumber);
            }
            else if (this.FirstNumber.Length > this.SecondNumber.Length)
            {
                return MyultiplicationAciton(this.SecondNumber, this.FirstNumber);
            }
            else
            {
                return MyultiplicationAciton(this.FirstNumber, this.SecondNumber);
            }
            return "";
        }
        public string Adiiton_myultiplication_numbers()
        {
            EqualsLenght();
            int oneOnMind = 0;
            string resultFromAdition = "";
            for (int i = 0; i < this.SecondNumber.Length; i++)
            {
                int a = ConvetChar(this.FirstNumber[i].ToString());
                if (oneOnMind == 1)
                {
                    a += oneOnMind;
                }
                int b = ConvetChar(this.SecondNumber[i].ToString());
                int middleResult = a + b;
                oneOnMind = 0;
                if (middleResult > 9)
                {
                    string index = middleResult.ToString();
                    resultFromAdition += index[1];
                    oneOnMind = Convert.ToInt32(index[0]);
                }
                resultFromAdition += middleResult;

            }
            return this.result = RevereResult(resultFromAdition);
        }
        
        public string Division()
        {
            return "";
        }



        public int ConvetChar(string num)
        {
            int a = int.Parse(num);
            return a;

        } 
        public string RevereResult(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string LengthEqualization(string a , string b)
        {
            int lengthA = a.Length;
            int lengthB = b.Length;
            int substractionLength = lengthB - lengthA;

            List<string> list = new List<string>();
            list.Add(a);
            for (int i = 0; i < substractionLength; i++)
            {
                list.Add(list[i] += "0");
            }
            return list[substractionLength];
        }
    }
}

