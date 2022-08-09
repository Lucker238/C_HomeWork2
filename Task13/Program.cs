void findThird()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number.ToString().Length];
    string result = "";

    int i = array.Length;
    while(number > 0)
        {
            i--;
            array[i] = number % 10;
            number = number / 10;
        }

    if(array.Length < 3) result = "Третьей цифры нет";
    else result = Convert.ToString(array[array.Length - 3]);
    
    Console.WriteLine(result);
}

findThird();
