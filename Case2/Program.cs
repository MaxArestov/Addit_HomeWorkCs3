//  2. Написать метод который принимает параметр и проверяет четное число или нет
//  если число четное то вывести результат деления на 2 в параметр с out Возвращающий тип будет bool.
Console.Clear();
int a = new int();
if (IsEvenAndHalf(a, out int b))
{
    Console.WriteLine($"Число четное. При делении на 2 получаем {b}");
}
else Console.WriteLine("Число нечетное");





bool IsEvenAndHalf(int digit, out int num)
{
    bool check = true;
    while (check)
    {
        Console.WriteLine("Введите число:");
        bool isParsed = int.TryParse(Console.ReadLine(), out digit);
        if (!isParsed)
        {
            Console.WriteLine("Введены некорректные данные.");
        }
        else check = false;
    }
    if (digit % 2 == 0)
    {
        num = digit / 2;
        return true;
    }
    else
    {
        num = default;
        return false;
    }
}