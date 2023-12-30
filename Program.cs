//Задача 1 на кратность 7 и 23.
// int a = Convert.ToInt32(Console.ReadLine());

// if (a%7==0 && a%23==0)
// {
//     Console.WriteLine("Число делится на 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число не делится на 7 и 23 ");
// }
// Задача 2 на нахождения плоскости x, y по вводным данным.
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x>0&&y>0&& x!=0 && y!=0)
{
    Console.WriteLine("1");
}
if (x>0&&y<0&& x!=0 && y!=0)
{
    Console.WriteLine("4");
}
if (x<0&&y<0&& x!=0 && y!=0)
{
    Console.WriteLine("3");
}
if (x<0&&y>0&& x!=0 && y!=0)
{
    Console.WriteLine("2");
}
if ( x==0 || y==0)
   {
    Console.WriteLine("`x` или `y` равна нулю");
}