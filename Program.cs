Console.WriteLine("******** Çalışan 1  *******");
Calisanlar calisan1 = new Calisanlar("İsmail", "Kara", 1245697, "Bilgi İşlem");
calisan1.CalisanBilgileri();

Console.WriteLine("******* Çalışan 2********");
Calisanlar calisan2 = new Calisanlar("Gamze", "Kayış", 541623164, "Pazarlama");
calisan2.CalisanBilgileri();

Console.WriteLine("******* Çalışan 3********");
Calisanlar calisan3 = new Calisanlar("Melih", "ÖZASLAN");
calisan3.CalisanBilgileri();


class Calisanlar
{
    public string Ad;

    public string Soyad;

    public int No;

    public string Departman;


    public Calisanlar(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;

    }

    public Calisanlar(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisanlar() { }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
    }

}