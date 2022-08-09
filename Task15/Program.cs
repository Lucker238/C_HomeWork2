void isHolliday()
{
    Console.Write("Введите число дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string result = "";
    if(number % 6 == 0 || number % 7 == 0) result = "Да!";
    else result = "Нет!";
    
    Console.WriteLine(result);
}

isHolliday();