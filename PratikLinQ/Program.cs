//Liste tanımlama
List<int> numbers = new List<int>();

//Rastgele sayı üretip listeye ekleme
int sayi = 0;
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    numbers.Add(rnd.Next(-100,100));
}   

//Sayıları ekrana yazdırma
Console.WriteLine("-------------- Liste Elemanları -------------------");
foreach (var i in numbers)
{
    Console.WriteLine(i);
}

//Çift sayı olanlar
Console.WriteLine("------------- Çift Sayılar --------------------------");
var evenNumber = numbers.Where(num => num % 2 == 0);
foreach (var number in evenNumber)
{ Console.WriteLine(number); }

//Tek sayı olanlar
Console.WriteLine("------------- Tek Sayılar --------------------------");
var oddNumber = numbers.Where(num => num % 2 != 0);
foreach (var number in oddNumber)
{ Console.WriteLine(number); }

//Posizitif
Console.WriteLine("------------- Pozitif Sayılar --------------------------");
var positiveNumber = numbers.Where(num => num > 0);
foreach (var number in positiveNumber)
{ Console.WriteLine(number); }

//Negatif
Console.WriteLine("------------- Pozitif Sayılar --------------------------");
var negativeNumber = numbers.Where(num => num < 0);
foreach (var number in negativeNumber)
{ Console.WriteLine(number); }

//15ten büyük 22den küçük sayılar
Console.WriteLine("------------- 15'den büyük 22den küçük sayılar --------------------------");
var result = numbers.Where(num => num > 15 && num < 22);
foreach (var number in result)
{ Console.WriteLine(number); }

//sayıların karesi
Console.WriteLine("------------- Sayıların Karesi ----------------------");
var squareList = numbers.Select(num => num * num).ToList();
foreach (var item in squareList)
{
    Console.WriteLine(item);
}