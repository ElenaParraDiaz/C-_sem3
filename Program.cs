/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*int num,r,sum=0,t;
Console.Write("Enter a five-digit number: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} palindrome");
else
Console.Write($"{t} not palindrome");
} else
Console.Write("Error! Enter not five-digit number!");
*/
/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*int InputN(string message)
{
Console.Write($"{message}> ");
int value;
if (int.TryParse(Console.ReadLine(), out value))
{
return value;
}
Console.WriteLine("Error. It's not a number");
Environment.Exit(1);
return 0;

}

int x1 = InputN ("Enter the X coordinate of point A");
int y1 = InputN ("Enter the Y coordinate of point A");
int z1 = InputN ("Enter the Z coordinate of point A");
int x2 = InputN ("Enter the X coordinate of point B");
int y2 = InputN ("Enter the Y coordinate of point B");
int z2 = InputN ("Enter the Y coordinate of point B");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2 - x1;
int deltay = y2 - y1;
int deltaz = z2 - z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}
Console.Write($"Distance between A and B {dis(x1, y1, z1, x2, y2, z2):F2} ");
*/
/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
4
1 - 1
2 - 8
3 - 27
4 - 64
*/
void Pow3(int pow)
{
    int count = 1;
    while(count <= pow)
    {
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}
Console.Write("Input number: ");
int Pow=Convert.ToInt32(Console.ReadLine());
Pow3(Pow);