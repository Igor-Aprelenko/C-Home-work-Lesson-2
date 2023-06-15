//  Напишите программу, которая принимает на вход цифру,обозначающую 
//  день недели, и проверяет, является ли этот день выходным. 

int ReadInt(string message)
{
System.Console.Write(message); 
int number = Convert.ToInt32(Console.ReadLine()); 
return number; 
}
int day = ReadInt("Введите номер дня недели -> ");

if (day > 7)
{
    System.Console.WriteLine("Такого дня недели не существует");
}
else if (day ==6 || day == 7)
{
    System.Console.WriteLine("Ура выходной");
}
else 
{
    System.Console.WriteLine("Увы будний день");
}



