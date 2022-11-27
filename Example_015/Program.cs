/*Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.*/
 Console.WriteLine("Введите цифру, обозначающую день недели");
 int day = Convert.ToInt32(Console.ReadLine());
 if (day == 1)
 {
    Console.WriteLine("monday"); 
 }
 else if (day == 2)
{
    Console.WriteLine("tuesday"); 
}
else if (day == 3)
{
    Console.WriteLine("wednesday");    
}
else if (day == 4)
{
    Console.WriteLine("thursday");    
}
else if (day == 5)
{
    Console.WriteLine("friday");    
}
else if (day == 6)
{
    Console.WriteLine("saturday");    
}
else if (day == 7)
{
    Console.WriteLine("sunday");
}
else 
{
    Console.Write("This day does not exist at this moment in time ");
}