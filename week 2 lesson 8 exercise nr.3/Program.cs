using System.Data;

int wynik;
int a = 1;
int b = 1;
int c;
int d;
Console.WriteLine(a);
Console.WriteLine(b);
for (int i = 1; i < 45; i++)
{
   
    c = a + b;
    d = b;
    b = c;
    a = d;
    Console.WriteLine(c);
}