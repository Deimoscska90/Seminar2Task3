int numberRequest(string message)
 {
Console.WriteLine(message);
int number = Convert.ToInt32(Console.ReadLine());
return number; 
 }

int Enternumber = numberRequest("Введите число:");

if (Enternumber == 6 || Enternumber == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}



