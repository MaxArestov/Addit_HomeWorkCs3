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
    int count = HowMuchItems(a, out int a1);
    Console.WriteLine(count);
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
    bool check = int.TryParse(s, out int s1);
    if (check)
    {
        for (i = 0; s1 != 0; i++)
        {
            s1 /= 10;
        }
    }
    s2 = s1;
    return i;
}
void IntToArray(int index, int figure, out int[] result)
{
    result = new int[index];
    for (int i = 0; i < index; i++)
    {
        result[index] = figure % 10;
        figure /= 10;
    }
}
void PrintArray(int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        Console.WriteLine($"{res[i]} ");
    }
}