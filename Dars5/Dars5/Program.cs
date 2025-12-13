using System;

namespace Dars5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            //Console.Write("List kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //var counter = 0;
            //List<int> ints = new List<int>();
            //for (int i = 0;i < N; i++)
            //{
            //    Console.Write("Elementlarni kiriting: ");
            //    var num=int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //    if (num <= 999 && num > 99)
            //    {
            //        counter++;
            //    }
            //}
            //Console.Write(counter);

            //#2

            //Console.Write("List kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();
            //var counter = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Elementlarni kiriting: ");
            //    var num = int.Parse(Console.ReadLine());
            //    ints.Add(num);

            //    if (num % 2 == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.Write(counter);

            //#3

            //Console.Write("List kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();

            //var sum = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Elementlarni kiriting: ");
            //    var num=int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //    if (num % 2 != 0)
            //    {
            //        sum += num;
            //    }
            //}
            //Console.Write(sum);

            //#4

            //Console.Write("List kiriting: ");
            //var N =int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();

            //var counter = 0;
            //for(int i=0; i < N; i++)
            //{
            //    Console.Write("Elementlarni kiriting: ");
            //    var num=int.Parse(Console.ReadLine());
            //    ints.Add(num);

            //    if (num % 3 == 0 && num % 7 == 0)
            //    {
            //        counter++;
            //    }

            //}
            //Console.Write(counter);

            //#5
            //Console.Write("List kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();
            //var counter = 0;
            //var sum = 0;

            //for(int i = 0; i < N; i++)
            //{
            //    Console.Write("Elementlarni kiriting: ");
            //    var num=int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //    if (num % 2 != 0 && num>9 && num <= 99)
            //    {
            //        counter++;
            //        sum += num;
            //    }
            //}
            //Console.WriteLine(counter);
            //Console.Write(sum);

            //#6

            //Console.Write("List kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Elementlarni kiriting: ");
            //    var num = int.Parse(Console.ReadLine());
            //    ints.Add(num);

            //}
            //if(ints.Count > 1)
            //{
            //    var temp = ints[0];
            //    ints[0] = ints[ints.Count - 1];
            //    ints[ints.Count - 1] = temp;
            //}
            //foreach (int list in ints)
            //{
            //    Console.Write(list + " ");
            //}

            //#7

            //Console.Write("List kiiritng: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> list = new List<int>();

            //var sum = 0;

            //Console.Write("Elementlarni kiriting: ");
            //for(int i = 0; i < N; i++)
            //{
            //    var nums=int.Parse(Console.ReadLine());

            //}
            //if (list.Count > 2)
            //{
            //    sum = list[0] + list[1] + list[2];
            //}
            //Console.Write(sum);

            //#8

            //Console.Write("Listni kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> list = new List<int>();

            //var sum = 0;
            //Console.Write("Elementlarni kiriting: ");
            //for(int i = 0; i < N; i++)
            //{
            //    var x = int.Parse(Console.ReadLine());
            //    list.Add(x);
            //}
            //if(list.Count > 3)
            //{
            //    sum = list[list.Count - 3] + list[list.Count - 2]+list[list.Count - 1];
            //}
            //Console.Write(sum);


            //#9 chala
            //Console.Write("Listni kiriting: ");
            //var N=int.Parse(Console.ReadLine());

            //List<int> list = new List<int>();

            //bool toq = false;
            //Console.Write("Elementlarni kiriting: ");
            //for(int i = 0; i < N; i++)
            //{
            //    var num=int.Parse(Console.ReadLine());
            //    list.Add(num);

            //    if ((i % 2 != 0)>(i%2==0))
            //    {
            //        toq = true;
            //    }
            //    else
            //    {
            //        toq = false;
            //    }
            //}

            //#10

            Console.Write("Listni kiriting: ");
            var N=int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            Console.Write("Elementlarni kiriting: ");
            for (int i = 0; i < N; i++)
            {
                var num=int.Parse(Console.ReadLine());
                list.Add(num);
                if (num % 2 == 0)
                {
                    
                }
            }


        }
    }
}
