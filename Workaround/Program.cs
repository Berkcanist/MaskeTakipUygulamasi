//Degiskenler();

static void Degiskenler()
{
    string message = "Hello World!";

    Console.WriteLine(message);
    double tutar = 100000; // db'den gelir
    int sayi = 100;
    bool girisYapmisMi = false;

    string name = "Berkcan";
    string surname = "Demir";
    int birthYear = 2002;
    long tcNo = 12345678910;


    Console.WriteLine(tutar * 1.18);
}


//Vatandas vatandas1 = new Vatandas();

SelamVer("Berkcan");
SelamVer("Engin");
SelamVer();

int sonuc = Topla(3,2);

// Arrays

string[] ogrenciler = new string[3];
ogrenciler[0] = "Berkcan";
ogrenciler[1] = "Engin";
ogrenciler[2] = "Kerem";
ogrenciler = new string[4];  // heap'te yeni bir bellek alanı tanımladığı için önceki değerler kayboldu (berkcan, egnin, kerem)
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Konya" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");
List<string> yeniSehirler2 = new List<string> { "Ankara", "İstanbul", "İzmir" };

Console.WriteLine("\n");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}
{

}

static void SelamVer(string Name="User")
{
    Console.WriteLine("Merhaba " + Name);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam " + sonuc.ToString()); // Console.WriteLine() fonksiyonun içinde olduğu için aslında .ToString() fonksiyonuna gerek yoktur
    return sonuc;
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}