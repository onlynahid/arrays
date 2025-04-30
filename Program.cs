// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
int[] numbers = { 2, 4, 5, 7, 8 };           
int sum = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];


    Console.WriteLine(sum);
}
////////////

 


 int[] numbers2 = { 7, 8, 9, 11, 18 };
int max = numbers2[0];
for (int i = 1; i < numbers2.Length; i++)    
{


    if (numbers2[i] > max)
    {



        max = numbers2[i];
         


        Console.WriteLine(max);
    }




}


/////////////

int[] numbers3 = { 11, 14, 17,21,23 };
int cem = numbers3[0] + numbers3[numbers3.Length - 1];    
Console.WriteLine(sum);


////////


double n = Convert.ToInt32(Console.ReadLine());
while (n % 2 == 0)
{
  n /= 2;
}
if ( n == 1)
{
Console.WriteLine("2 quvvetidir");
}
else
{
    Console.WriteLine(" 2 nin quvveti deyil");
}
/////////


int n = Convert.ToInt32(Console.ReadLine());
int say = 0;
if ( n == 0)
{
    say= 1;
}
else 
{
    if (n < 0) n = -n;

    while (n > 0)
    {

        n = n / 10;
        say++;


    }



}
Console.WriteLine(say);




///////////
///


int[] ededler = {3,7,9,11,13,17,21};
int b = Convert.ToInt32(Console.ReadLine());
int index = -1;
for (int i = 0; i < ededler.Length; i++)
{
    if ( ededler[i] == b)
    {
        index = i;
        break;



    }



}
Console.WriteLine(index);
