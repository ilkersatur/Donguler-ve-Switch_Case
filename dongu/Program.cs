// for , while , do while 
// foreach yukardakilerden farklı 
//for (int i = 1; i<=10; i++)
//{
//Console.WriteLine(i);
//}
/* 
dongüler çalışma mekaniği olarak ikiye ayrılır
1- ne kadar çalışacağı belli olan döngüler  ----- for
    başlanıç  int=i
    şart      i<10
    yaklaşma  i++, i--
2- belli olmayan döngüler --------- while




for (int i = 30; i >= 0; i-=3)
{
    Console.WriteLine(i);
}


// gelen sayıları ard arda toplamak için yeni bir toplam tanımla
int toplam = 0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("sayı gir");
    int sayi = Convert.ToInt16(Console.ReadLine());  // yoksa sayı+=sayı yaparsan ReadLine'dan
    toplam += sayi;                                  // gelen değer toplamını değiştirir
}
Console.WriteLine( toplam);
*/

// yüze kadar toplam
//int toplam = 0;
//for (int i = 1; i <= 100; i++)
//{
//    toplam += i;                                  
//}
//Console.WriteLine(toplam);


//faktöriyel

int toplam = 1;
for (int i= Convert.ToInt16(Console.ReadLine()); 1 <= i; i--)
{
    toplam *= i;
}
Console.WriteLine($"{toplam}"); 