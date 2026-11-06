public class Sekolah
{
    public string idSekolah;
    public string namaSekolah;
    public int jumlahPaketDiterima;

    public void Tampilinfo()
    {
        Console.WriteLine("Id Sekolah : " + idSekolah);
        Console.WriteLine("Nama Sekolah : " + namaSekolah);
        Console.WriteLine("Jumlah Paket yang diterima : " + jumlahPaketDiterima);
    }
}
abstract class PaketMBG
{
    private string idPaket;
    private string namaPaket;
    private int stokDapur;


    public string IdPaket { get { return idPaket; } set { idPaket = value; } }
    public string NamaPaket { get { return namaPaket; } set { namaPaket = value; } }
    public int StokDapur { get { return stokDapur; } set { stokDapur = value; } }

    public PaketMBG(string id, string nama, int stok)
    {
        IdPaket = id;
        NamaPaket = nama;
        StokDapur = stok;
    }
    public class HitungBiaya();
}

class PaketReguler : PaketMBG
{
}

class PaketKhusus : PaketMBG
{

}
public class PengelolaMBG
{

}

public class KurangiStok(int Jumlah)
{
}

class program
{
    static void Main()
    {
        Sekolah sekolah = new Sekolah();
    }
}