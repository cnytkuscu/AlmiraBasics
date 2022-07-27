
//int               tam sayı, sayısal değer  1 2 3 4 5 
//string            metin b a g ' ? _ 6
//double            1.26 498.782134
//float             640.00
//bool <> bit       0 || 1
//var               HEPSİ
//char              'a' 'u' '_'

//5 + 9 = 14  int var
//Almira + Cuneyt = string, var AlmiraCuneyt
//if(9 > 10) = bit
//10$ 150.65  = double var float

//Kullanıcı Profili (İsim, Yaş ve Cinsiyet)  N adet olabilir.

List<string> isimList = new List<string>();
List<int> yasList = new List<int>();
List<bool> cinsiyetList = new List<bool>();

Console.Write("Kac Kullanici Girilecek : ");
int profileNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < profileNumber; i++)
{
    Console.Write("İsim Listesinini " + (i + 1) + ". ismini giriniz : ");
    isimList.Add(Console.ReadLine());

    Console.Write("Yaş Listesinini " + (i + 1) + ". yaşını giriniz : ");
    yasList.Add(Convert.ToInt32(Console.ReadLine()));

    Console.Write("Cinsiyet Listesinini " + (i + 1) + ". cinsiyetini giriniz : ");
    cinsiyetList.Add( Convert.ToBoolean(Console.ReadLine()));
}

for (int i = 0; i < profileNumber; i++)
{
    Console.WriteLine(isimList[i] + " -- " + yasList[i] + " -- " + (cinsiyetList[i] == true ? "Kadin" : "Erkek"));
}




Console.ReadKey();






