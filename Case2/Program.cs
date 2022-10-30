//  2. Написать метод который принимает параметр и проверяет четное число или нет
//  если число четное то вывести результат деления на 2 в параметр с out Возвращающий тип будет bool.
Console.Clear();
int a = FillVar();
if (IsEven(a))
{
    Console.WriteLine($"Число четное. При делении на 2 получается {a / 2}");
}
else Console.WriteLine("Число нечетное.");






bool IsEven(int num)
{
    if (num % 10 == 0)
    {
        return true;
    }
    else return false;
}
int FillVar()
{
    int num = 0;
    Console.WriteLine("Введите число: ");
    bool check = true;
    while (check)
    {
        bool parse = int.TryParse(Console.ReadLine(), out num);
        if (!parse)
        {
            Console.WriteLine("Введены некорректные данные");
        }
        else
        {
            check = false;
        }
    }
    return num;
}