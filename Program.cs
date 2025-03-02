// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace csharp_7_oop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Ad = "Ahmet";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.TcKimlikNo = "12345678901";
            // ogrenci.TcKimlikNo = "1234567890";
            Console.WriteLine("1nd student: " + ogrenci.Ad);
            Console.WriteLine("1nd student: " + ogrenci.Soyad);
            Console.WriteLine("1nd student: " + ogrenci.TcKimlikNo);

            ogrenci.Ad = "Ali";
            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine("--------------------------------------------------");

            Ogrenciler ogrenci1 = new Ogrenciler();
            ogrenci1.Ad = "Mehmet";
            ogrenci1.Soyad = "Yılmaz";
            ogrenci1.TcKimlikNo = "12345678901";
            // ogrenci1.TcKimlikNo = "1234567890";
            Console.WriteLine("2nd student: " + ogrenci1.Ad);
            Console.WriteLine("2nd student: " + ogrenci1.Soyad);
            Console.WriteLine("2nd student: " + ogrenci1.TcKimlikNo);
        }
    }
}
