// 4. Сделать метод (аналог TryParse) который принимает на вход строку и параметр с модификатором out и пытается преобразовать в число
// если получилось то возвращается true, если нет то false
Console.Clear();
Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int figure = new int();
Console.WriteLine(StringToInt(number, out figure));




bool StringToInt(string enter, out int export)
{
    try
    {
        export = Convert.ToInt32(enter);
        return true;
    }
    catch (System.Exception)
    {
        export = -0;
        return false;
    }
}