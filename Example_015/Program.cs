/*Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.*/
 Console.WriteLine("Введите цифру, обозначающую день недели"); // Выводим приглашение
 int day = Convert.ToInt32(Console.ReadLine());                // Присваиваем переменную day тому числу, который введет user
 if (day == 1)      // Если day равен 1, то выводим, что это понедельник.
 {
    Console.WriteLine("monday"); // anal
 }
 else if (day == 2)
{
    Console.WriteLine("tuesday"); // anal
}
else if (day == 3)
{
    Console.WriteLine("wednesday"); // anal   
}
else if (day == 4)
{
    Console.WriteLine("thursday");    // anal
}
else if (day == 5)
{
    Console.WriteLine("friday");    // anal
}
else if (day == 6)
{
    Console.WriteLine("saturday");    // а этот неплох
}
else if (day == 7)
{
    Console.WriteLine("sunday"); // a этот неплох
}
else // иначе выводим фразу, что такого дня нет.
{
    Console.Write("This day does not exist at this moment in time ");
}
// можно слепить через массив
/* string[]days;
    day[0] = Monday;
    day[1] = Tuesday;
    day[2] = Wednessday;
    day[3] = Thursday;
    day[4] = Friday;
    day[5] = Saturday;
    day[6] = Sunday;
   String day = days[chislo-1];   */