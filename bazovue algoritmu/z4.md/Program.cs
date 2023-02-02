////Напишите программу, которая принимает на вход два числа и proveryaet является ли odno число кvadratom drygomy
//5,25 ->da  8,9 ->net


System.Console.WriteLine ("vvedite chislo");
int a = Convert.ToInt32((Console.ReadLine));


System.Console.WriteLine("vvedite chislo");
int b = Convert.ToInt32((Console.ReadLine));

if (a==b*b)
{
    System.Console.WriteLine($"chislo {b} eto kvadrat {a}");
}
else  if (b==a*a)
{
 System.Console.WriteLine($"chislo {a} eto kvadrat {b}");

}
else
{
System.Console.WriteLine($"ni odno chislo ne yavl kvadratom dryg dryga");
  
}
