/*

Console.Write("sayi1 gir ");
int sayi1=Convert.ToInt16(Console.ReadLine());
Console.Write("sayi1 gir ");
int sayi2 = Convert.ToInt16(Console.ReadLine());

if (sayi1<sayi2)
{
    Console.WriteLine($"{sayi2}, {sayi1}'den büyüktür");
}
else if (sayi2 < sayi1)
{
    Console.WriteLine($"{sayi1}, {sayi2}'den büyüktür");
}
else
{
    Console.WriteLine($"{sayi1} = {sayi2}");
}


*/
/*

Console.Write("kullanıcı adı");
string id = (Console.ReadLine());
Console.Write("şifre ");
string sifre = (Console.ReadLine());

if (id=="ilker" && sifre=="satur")
{
    Console.WriteLine("giriş başarılı ");
}

else
{
    Console.WriteLine("giriş başarısız");
}

*/


Console.Write("harf gir ");
char id =Convert.ToChar(Console.ReadLine());

if (id == 'E' || id == 'e')
{
    Console.WriteLine("giriş başarılı ");
}

else
{
    Console.WriteLine("giriş başarısız");
}