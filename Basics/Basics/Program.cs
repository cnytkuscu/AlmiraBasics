
//int               tam sayı, sayısal değer  1 2 3 4 5 
//string            metin b a g ' ? _ 6
//double            1.26 498.782134
//float             640.00
//bool <> bit       0 || 1
//var               HEPSİ
//char              'a' 'u' '_'


/*   1 - Girilen 2 sayının tutulduğu değişkenleri değiştir a = 10, b = 20--->a = 20, b = 10 yapacak.


int numberOne, numberTwo, temp;

Console.Write("Lütfen bir Sayı Giriniz : ");
numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Lütfen bir Sayı daha Giriniz : ");
numberTwo = Convert.ToInt32(Console.ReadLine());

temp = numberOne;
numberOne = numberTwo;
numberTwo = temp;

Console.WriteLine("NumberOne = " + numberOne + " NumberTwo = " + numberTwo);

*/

/*2- Girilen Celcius sıcaklığı fahrenhiet'a çeviren program

double celciusInput, fahrenheit;

Console.WriteLine("Celcius Değerini Giriniz : ");
celciusInput = Convert.ToDouble(Console.ReadLine());

if (celciusInput > 500 || celciusInput < -500)
{
    Console.WriteLine("Girilen Celcius Çok Büyüktür/Küçüktür.");
}
else
{
    fahrenheit = celciusInput * 2.155;
    Console.WriteLine("Fahrenheit Değeri : " + fahrenheit);
    Console.WriteLine("Fahreheit'ı Kelvin'e çevireyim mi ?  E/H");

    string userInput = Console.ReadLine();
    if (userInput == "E")
    {
        double kelvin = 0;        
        kelvin = fahrenheit * 32;
        Console.WriteLine("Kelvin : "+kelvin);
    }
    else if (userInput == "H")
    {
        Console.WriteLine("Cya later bby <3");
    }
    else
    {
        Console.WriteLine("Hatalı giriş yaptınız. Şimdi en baştan dene bakalım qnq.");
    }
}

*/

/*3 - Girilen gün sayısının ve kullanıcın seçtiği "Hafta" ya da "Ay" değerine dönüşümü 
    135 gün, Ay -> 4 Aydır  |||| 135 gün, Hafta -> 19 hafta. 1 ay 30 gün, 1 hafta 7 gün olarak hesaplayacak.

int dayCount;
string IsWeekOrMonth;

Console.WriteLine("Gun Sayisi Giriniz : ");
dayCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Girilen Gün Sayısını Hafta olarak mı Yoksa Ay olarak mı İstiyorsunuz ? A/H");
IsWeekOrMonth = Console.ReadLine();
if(IsWeekOrMonth == "A")
{
    int monthCount = dayCount / 30;
    Console.WriteLine("Girdiğiniz Gün Sayısı "+dayCount+" gündür ve "+monthCount+" aydır.");
}
else if (IsWeekOrMonth == "H")
{
    int weekCount = dayCount / 7;
    Console.WriteLine("Girdiğiniz Gün Sayısı " + dayCount + " gündür ve " + weekCount + " haftadır.");
}
else
{
    Console.WriteLine("Hatalı Giriş Yaptınız. BB");
}

*/

/*4 - Girilen Yılın artık yıl mı yoksa normal yıl mı olduğunu yazdır

int year;

Console.WriteLine("Yıl değeri giriniz ");
year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0)
{
    Console.WriteLine("Artık Yıldır");
}
else
{
    Console.WriteLine("Artık Yıl Değildir.");
}
*/

/*5 - Girilen sayıya göre haftanın gününü yazacak, 7'den büyük girilirse, kullanıcıya mesaj gösterilip tekrar gün istenecek

int dayNumber;


soruSor:
Console.Write("Gün Sayısı Giriniz :");
dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber < 8 && dayNumber > 0)
{
    if (dayNumber == 1) Console.WriteLine("Pazartesi");
    if (dayNumber == 2) Console.WriteLine("Salı");
    if (dayNumber == 3) Console.WriteLine("Çarşamba");
    if (dayNumber == 4) Console.WriteLine("Perşembe");
    if (dayNumber == 5) Console.WriteLine("Cuma");
    if (dayNumber == 6) Console.WriteLine("Cumartesi");
    if (dayNumber == 7) Console.WriteLine("Pazar");
}
else
{
    Console.WriteLine("Hatalı Giriş Yaptınız."); goto soruSor;
}

*/

//6 - Girilen sayıya kadar olan çift sayıların toplamını bulan program yazılacak. 8 için 0+2+4+6 = 12 diyecek. 4 için 0+2 = 2 diyecek


int number = 0;
Console.WriteLine("Toplanacak Üst Limiti Giriniz : ");
number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 0; i < number; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + i;
    }
}
Console.WriteLine("Toplam :" + sum);



Console.WriteLine("Kare boyunutunu Giriniz : ");
int length = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write("*");
        for (int k = 0; k < length; k++)
        {
            Console.Write("-");
        }
    }
    Console.WriteLine();
}






Console.ReadKey();














