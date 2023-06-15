// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Не использовать строки

int ReadInt(string message)
{
System.Console.Write(message); 
int number = Convert.ToInt32(Console.ReadLine()); 
return number; 
}
int num = ReadInt("Введите число -> ");
if (num < 100)
{
System.Console.WriteLine("В чсиле нет 3-ей цифры");
}
else
{
while (num > 999)
{
    num = num / 10;
}
int digit = num % 10;
System.Console.WriteLine($"Третья цифра числа равна {digit}");
}