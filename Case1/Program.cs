// 1. Написать метод который принимает два числа и меняет значения местами используя ref.
Console.Clear();
int a = FillVar();
int b = FillVar();
Console.WriteLine($"Введены числа а - {a}, b - {b}");
SwapValue(ref a, ref b);
Console.WriteLine($"Значение а после замены - {a}, значение b после замены - {b}");


















int FillVar()
{
    int num = 0;
    bool check = true;
    while(check)
    {
        Console.WriteLine("Введите число: ");
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
void SwapValue(ref int num1, ref int num2)
{
    int helper = num1;
    num1 = num2;
    num2 = helper;
}