//  3. Написать метод который из числа делает массив. Возвращает bool массив кладет в параметр с модификатором out.
//  В случае если не удалость преобразовать возвращается false. Если удалось то true.
Console.Clear();
Console.Write("Введите число: ");
string a = Console.ReadLine();
if (!CharIsDigit(a))
{
    Console.WriteLine("false");
}
else
{
    int a1 = 2;
    int count = HowMuchItems(a, out a1);
    IntToArray(count, a1, out int[] result);
    PrintArray(result);
}



bool CharIsDigit(string digit)
{
    foreach (var item in digit)
    {
        if (!char.IsDigit(item))
        {
            return false;
        }
    }
    return true;
}
int HowMuchItems(string s, out int s2)
{
    int i = 0;
    int s1 = 0;
    bool check = int.TryParse(s, out s1);
    s2 = s1;
    if (check)
    {
        for (i = 0; s1 != 0; i++)
        {
            s1 /= 10;
        }
    }
    return i;
}
void IntToArray(int index, int figure, out int[] result1)
{
    result1 = new int[index];
    for (int i = 0; figure != 0; i++)
    {
        result1[index - 1 - i] = figure % 10;
        figure /= 10;
    }
}
void PrintArray(int[] res)
{
    Console.WriteLine("Массив:");
    Console.Write("[");
    for (int i = 0; i < res.Length; i++)
    {
        if (i < res.Length - 1)
        {
            Console.Write($"{res[i]}, ");
        }
        else Console.Write($"{res[i]}");
    }
    Console.WriteLine("]");
}