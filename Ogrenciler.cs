namespace csharp_7_oop_2;

public class Ogrenciler
{
    string ad; // default: internal
    private string soyad; // private: sadece bu sınıf erişebilir.
    protected string tcKimlikNo; // protected: sadece bu sınıf ve bu sınıftan türetilen sınıflar erişebilir.

    public string Ad
    {
        get => ad;
        set => ad = value;
    }

    public string Soyad
    {
        get => soyad;
        // set => soyad = value;
        set
        {
            if (value.Length < 2)
            {
                throw new Exception("Soyad en az 2 karakter olmalıdır.");
            }
            soyad = value;
        }
    }

    public string TcKimlikNo
    {
        get => tcKimlikNo;
        set
        {
            if (value.Length != 11)
            {
                throw new Exception("Tc Kimlik No 11 karakter olmalıdır.");
            }
            tcKimlikNo = value;
        }
    }

}
