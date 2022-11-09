int i =Convert.ToInt16(Console.ReadLine());
switch (i)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
    case 5:
        Console.WriteLine("4 ya da 5");
        break;

    default:
        Console.WriteLine("1-2-3-4-5 değil");
        break;
}