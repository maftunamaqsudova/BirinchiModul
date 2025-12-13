using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Dars6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine(Calculate(2, 3, 4));
            //Console.WriteLine(Calculate(5, 6));
            //Console.WriteLine(GetAmountDigit( 4));
            //Console.WriteLine(GetAmountDigit("Dgfhe3yu3y9thbegui35"));
            //Console.WriteLine(GetMax(3,56, 73, 345, 1));

            //Console.WriteLine(Multiplication(3));

            //Console.WriteLine(Rooms(45));
            //Console.WriteLine(SummOfNumbers(5, 8));
            // Console.WriteLine(KubOfNumbers(5));

            //Console.WriteLine(AbsNum(-5));
            //Console.WriteLine(AbsNum(66));
            //Console.WriteLine(AbsNum(0));

            Console.Write()

        }
        static float Add (float a, float b)
        {

            return a + b;
        }
        static float Add (float a, float b, float c)
        {
            return a + b + c;
        }
        static string Add(string a, string b)
        {
            return a + b;
        }


        static int Calculate (int a, int b, int c)
        {
            
            int mult = a * b * c;

            return mult;
        }
        static int Calculate (int a, int b)
        {
            return a + b;
        }

        static void Repeat (int a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.Write(a + " ");
            }
        }
        static void Repeat (int a)
        {
            for(int i = 0; i < a; i++)
            {
                Console.Write(a + " ");
            }
           
        }

        static int GetAmountDigit (int num)
        {
            num = Math.Abs(num);

            return num.ToString().Length;
        }

        static int GetAmountDigit(string str, int counter=0)
        {
            for (int i=0; i<str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    counter++;
                }
            }
            return counter;
        }


        static int GetMax (int num1, int num2, int num3)
        {

            int max = Math.Max(num1,Math.Max(num2, num3));
            return max;
        }
        static int GetMax (int num1, int num2, int num3, int num4)
        {
            int max = Math.Max(num1, Math.Max(num2,Math.Max (num3, num4)));
            return max;
        }
        static int GetMax (int num1, int num2, int num3, int num4, int num5)
        {
            int max = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));
            return max;
        }


        static int Multiplication(int num)
        {
            int mult = 1;
            for(int i = 1; i <= num; i++)
            {
                mult *= i;
            }
            return mult;
        }
        static int Multiplication(int num1, int num2)
        {
            int mult = 1;
            for(int i = num1; i <= num2; i++)
            {
                mult *= i;
            }
            return mult;
        }
        static int Multiplication (int num1, int num2, int num3)
        {
            int mult = num2 * num2 * num3;
            return mult;
        }


        static int Rooms (int num)
        {
            if (num == 0)
            {
                return 0;
            }
            num = Math.Abs(num);
            return num.ToString().Length;
        }

        static int SummOfNumbers (int num1, int num2)
        {
            if (num1 > num2)
            {
                return 0;
            }
            return num1+SummOfNumbers(num1+1, num2);
        }


        static int KubOfNumbers (int num)
        {
          
            if (num == 0)
            {
                return 0;
            }

            return num*num*num + KubOfNumbers(num-1);
        }

        static int AbsNum (int num)
        {
         
            if(num == 0)
            {
                return 0;
            }
            if (num > 0)
            {
                return num;
            }
            return num * (-1);
        }
        static int AbsN(int n)
        {
            return (n < 0) ? -n : n;
        }


        static int MaxNum (int num1, int num2)
        {
            return num1<num2 ? num2 : num2;
        }

        static int MaxxNum (int[] arr, int num)
        {
            if (num == 1)
            {
                return arr[0];
            }
            int max = MaxxNum(arr , num-1);
            return arr[num-1]>max ? arr[num-1] : max;
        }



        static string Isupper (string str)
        {
            
            string uppers =""; ;
            for (int i =0;i<str.Length;i++)
            {
                if (str[i] >= 65 && str[i]<91)
                {
                    uppers += str[i];
                }
            }
            return uppers ;
        }static int IsUpperCount (string str)
        {
            int counter = 0;
             ;
            for (int i =0;i<str.Length;i++)
            {
                if (str[i] >= 65 && str[i]<91)
                {
                    counter++;
                }
            }
            return counter;
        }
        
        //static string ToUpperString (string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        str += i;
        //        if(str[i] >=97 && str[i] <= 122)
        //        {
        //            Isupper=str[i];
        //        }
        //    }
        //}

    }
}
