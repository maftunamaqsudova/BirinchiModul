using System.Globalization;

namespace Dars3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#1

int hour = 2;
int minute = 60;
Console.WriteLine("2 soat=" + minute * hour+" minutga");

#2

int week = 5;
int day = week * 7;
int hour = 24;
Console.WriteLine("5 haftada " + day * hour + " soat bor.");

#3

int minute = 4;
int second = 60;
Console.WriteLine("4 minut " + minute * second + " sekundga teng.");

#4

int hour = 25;
int minute = 60*hour;
int second = 60;
Console.WriteLine("25 soat " + second * minute + " sekundga teng.");

#5

int week = 150;
int day = week * 7;
int hour = 24;
Console.WriteLine("150 hafta " + hour * day + " soatga teng.");

#6

int day = 4;
int hour = 24 * day;
int minute = 60 * hour;
Console.WriteLine("4 kun "+ minute*day+" minutga teng.");

#7

int week = 150;
int day = 7 * week;
int hour = 24;
Console.WriteLine("150 hafta " + hour * day + " soatga teng.");

#8

int hour = 24;
Console.WriteLine("24 soat " + hour / 24 + " kunga teng");

#9

int day = 24;
int week = 7;
Console.WriteLine("24 kun "+day/week+" haftaga teng");

#10

int second = 3600;
int hour = 60*60;
Console.WriteLine("3600 sekund " + second / hour+" soatga teng.");

#11

 double second = 2400;
 double minute = 60;
 Console.WriteLine(second / minute);

#12

int second = 2419200;
int hour = second / (60*60);
int day = hour / 24;
int week = 7;
Console.WriteLine(day/week);

#2.1

int gb = 5;
int mb = 1024;
Console.WriteLine(gb*mb);

#2.2

int mb = 3;
int kb = 1024;
Console.WriteLine(mb*kb);

#2.3

int tb = 8;
int mb = 1024*1024;
Console.WriteLine(tb*mb);

#2.4

int gb = 5;
Console.WriteLine(gb*1024);

#2.5

int kb = 8;
Console.WriteLine(kb*1024);

#2.6

int MB = 4;
int KB = 1024;
int Bayt = 1024;
int Bit = 8;
Console.WriteLine(MB*KB*Bayt*Bit);

#2.7

int Bayt = 3;
int Bit = 8;
Console.WriteLine(Bayt*Bit);

#2.8

int Mb = 1;
int Kb = 1024;
Console.WriteLine(Mb * Kb);

#2.9

double TB = 8;
double KB = 1024 * 1024 * 1024;
Console.WriteLine(TB*KB);

#2.10

double MB = 12;
double Bayt = 1024 * 1024;
Console.WriteLine(MB*Bayt);

#2.11

double Gb = 5000;
double Tb = 1024;
Console.WriteLine(Gb / 1024);

#2.12

double Mb = 3000;
double Gb = 1024;
Console.WriteLine(Mb/Gb);

#2.13

double Bit = 12000;
double Bayt = Bit / 8;
double Kb = 1024;
Console.WriteLine(Bayt/Kb);

#2.14

int Kb = 2048;
int Mb = 1024;
Console.WriteLine(Kb/Mb);

#2.15

double Bit = 16000;
double Bayt = Bit / 8;
double Kb = 1024;
Console.WriteLine(Bit/Kb);

#2.16

double Bayt = 4096;
double Kb = 1024;
Console.WriteLine(Bayt/Kb);

#2.17

double Bit = 3200;
Console.WriteLine(Bit/8);

#2.18

float Kb = 1200;
Console.WriteLine(Kb / 1024);

#2.19

float bayt = 48000;
Console.WriteLine(bayt / 1024 / 1024);

#2.20

double mb = 120000;
Console.WriteLine(mb/1024/1024);

#2.21

int Mb = 3;
int Kb = 8;
Console.WriteLine(Mb*1024+8);

#2.22

int Gb = 7;
int Mb = 11;
Console.WriteLine(7*1024*1024+(Mb*1024));

#2.23

int mb = 3 * 1024 * 1024;
int kb = 82 * 1024;
Console.WriteLine(mb + kb);

#2.24

int bayt = 12 * 8;
int kb = 8*1024*8;
Console.WriteLine(bayt + kb);

#2.25

double mb = 4 * 1024 * 1024 * 8;
double kb = 10 * 1024 * 8;
Console.WriteLine(mb+kb);

#3.1



#4.1

Console.Write("Son kiriting:");
int n=int.Parse(Console.ReadLine());
Console.Write(n + 10);

#4.2

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n - 10);

#4.3

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n * 10);

#4.4

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n * n);

#4.5

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n * n * n);

#4.6

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n * n*n*n*n);

#4.7

Console.Write("1-chi sonni kiriting:");
int n = int.Parse(Console.ReadLine());
Console.Write("2-chi sonni kiriting:");
int m= int.Parse(Console.ReadLine());
Console.WriteLine(n+m);

#4.8

Console.Write("1-chi sonni kiriting:");
int n = int.Parse(Console.ReadLine());
Console.Write("2-chi sonni kiriting:");
int m= int.Parse(Console.ReadLine());
Console.WriteLine(n*m);

#4.9

Console.Write("1-chi sonni kiriting:");
int a = int.Parse(Console.ReadLine());
Console.Write("2-chi sonni kiriting:");
int b= int.Parse(Console.ReadLine());
Console.Write("3-chi sonni kiriting:");
int c= int.Parse(Console.ReadLine());
Console.Write("4-chi sonni kiriting:");
int d= int.Parse(Console.ReadLine());
Console.WriteLine(a+b+c+d);

#4.10

Console.Write("1-chi sonni kiriting:");
float a = float.Parse(Console.ReadLine());
Console.Write("2-chi sonni kiriting:");
float b = float.Parse(Console.ReadLine());
Console.Write("3-chi sonni kiriting:");
float c = float.Parse(Console.ReadLine());
Console.WriteLine((a + b + c)/3);

#4.11

float a = float.Parse(Console.ReadLine());
Console.Write("2-chi sonni kiriting:");
float b = float.Parse(Console.ReadLine());
Console.Write("3-chi sonni kiriting:");
float c = float.Parse(Console.ReadLine());
Console.Write("4-chi sonni kiriting:");
float d = float.Parse(Console.ReadLine());
Console.Write("5-chi sonni kiriting:");
float e = float.Parse(Console.ReadLine());
Console.WriteLine((a + b + c+d+e )/5);

#4.12
Console.Write("1-chi sonni kiriting:");
float a = float.Parse(Console.ReadLine());
Console.Write("2-chi sonni kiriting:");
float b = float.Parse(Console.ReadLine());
Console.Write("3-chi sonni kiriting:");
float c = float.Parse(Console.ReadLine());
Console.Write("4-chi sonni kiriting:");
float d = float.Parse(Console.ReadLine());
Console.Write("5-chi sonni kiriting:");
float e = float.Parse(Console.ReadLine());
Console.Write("6-chi sonni kiriting:");
float f = float.Parse(Console.ReadLine());
Console.Write("7-chi sonni kiriting:");
float g = float.Parse(Console.ReadLine());
Console.Write("8-hci sonni kiriting:");
float h = float.Parse(Console.ReadLine());
Console.WriteLine((a + b + c+d+e+f+g+h )/8);

#4.13

Console.Write("Son kiriting:");
int n=int.Parse(Console.ReadLine());
Console.Write("SOn kiriting:");
int n2=int.Parse(Console.ReadLine());
Console.Write(n-n+n2+" ");
Console.Write(n2 - n2 + n);

#4.14

Console.Write("Minute:");
int m=int.Parse(Console.ReadLine());
int s = m * 60;
Console.Write(s);

#4.15

Console.Write("Hour:");
int h=int.Parse(Console.ReadLine());
int s = h * 60 * 60;
Console.Write(s);

#4.16

Console.Write("Day:");
int d = int.Parse(Console.ReadLine());
int m = d * 24 * 60;
Console.Write(m);


#4.17

Console.Write("Minute:");
int m=int.Parse(Console.ReadLine());
int h = m / 60;
Console.Write(h);

#4.18

Console.Write("Minute:");
int m=int.Parse(Console.ReadLine());
int d = m / 60 / 24;
Console.Write(d);

#4.19

Console.Write("Yoshingizni kiriting:");
int n=int.Parse(Console.ReadLine());
int year = 2025 - n;
Console.Write(year);

#4.20

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
int l = n - 1;
int m = n + 1;
Console.Write(l);Console.Write(" "+m);

#4.21

Console.Write("Son kiriting:");
int n = int.Parse(Console.ReadLine());
int l = n - 10;
int m = n + 10;
Console.Write(l);Console.Write(" "+m);

#4.22

 Console.Write("Son kiriting:");
 int n=int.Parse(Console.ReadLine());
 Console.Write("Son kiriting:");
 int m=int.Parse(Console.ReadLine());
 int ayirmasi;
 int yigindisi=n+m;
 int kopaytmasi=n*m;
 int bolinmasi;

 if (n > m) bolinmasi = n / m; ayirmasi = n -m;
 if(m>n) ayirmasi = m-n; bolinmasi= m/n;

 Console.WriteLine(bolinmasi);
 Console.WriteLine(ayirmasi);
 Console.WriteLine(yigindisi);
 Console.WriteLine(kopaytmasi);

#4.23

Console.Write("Son kiriting:");
int n=int.Parse(Console.ReadLine());
int n3 = n * n * n;
int n4 = n * n * n * n;
int n5 = n * n * n * n * n;
Console.Write(n3+" ");Console.Write(n4+" ");Console.Write(n5);

#5.1

Console.Write("2ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int b = n % 10;
Console.Write(b);

#5.2

Console.Write("3ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int b = n /10%10;
Console.Write(b);

#5.3

Console.Write("3ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int b = n /10/10;
Console.Write(b);

#5.4

Console.Write("5ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int b = n /100/10%10;
Console.Write(b);

#5.5

Console.Write("4 ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int b= n / 100 %10;
Console.Write(b);

#5.6

Console.Write("3 ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int a = n / 100;
int b = n / 10%10;
int c = n % 10;
Console.WriteLine(a + b + c);

#5.7

Console.Write("3 ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int a = n / 100;
int b = n / 10%10;
int c = n % 10;
Console.WriteLine(a * b * c);

#5.8

Console.Write("3 ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int a = n / 10;
int b = n %10;
       
Console.WriteLine(a * b);

#5.9

Console.Write("5 ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int a = n / 10000;
int b = n / 1000%10;
int c = n /100%10;
int d = n /10%10;
int f = n % 10;
       
Console.WriteLine(a+b+c+d+f);

#5.10

Console.Write("3 ta xonali son kiriting:");
int n=int.Parse(Console.ReadLine());
int a = n / 100;
int b = n % 100/10;
int c = n % 10;
Console.Write(c);Console.Write(b);Console.Write(a);*/




            /* for(int i = 100; i >= 999; i++)
             {
                 int r1 = i / 100;
                 int r2 = i / 100 % 10;
                 int r3 = i % 10;

                 if (r1%2!=0 || r2%2!=0 || r3%2!=0)
                 {
                     Console.Write($"{i}, ");
                 }
             }*/

            Console.Write("1-chi sonni kiriting:");
            int a=int.Parse(Console.ReadLine());
            Console.Write("2 - chi sonni kiriting:");
            int b=int.Parse(Console.ReadLine());

            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < a; i++)
            {
                if(a%i == 0)
                {
                    counter1++;
                }
            }

            for (int i = 0; i < b; i++)
            {
                if (b % i == 0)
                {
                    counter2++;
                }
                if (counter1 == 2 || counter2 == 2)
                {
                    Console.Write($"{counter1 + counter2}");

                }
                else
                {
                    Console.Write($"{counter1 * counter2}");
                }



            }


        }
    }
}
