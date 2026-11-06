using System;

public class Sekolah(string id, string nama, int jumlah)
{
    string idSekolah = id;
    string namaSekolah = nama;
    int jumlahPaketDiterima = jumlah;

    public void TampilkanInfo()
    {
        Console.WriteLine(idSekolah, namaSekolah, jumlahPaketDiterima);
    }
}

class PaketMBG()
{
    private string idPaket { get; set; }
    private string namaPaket { get; set; }
    private int stokDapur { get; set; }

    public void _stokDapur()
    {
        get
        {
            int stokDapur;
        }

        set
        {
            if (stokDapur < 0)
            {
                Console.WriteLine("tidak boleh negatif!");
            }
        }
    }

    public void KurangiStok(int jumlah)
    {
        stokDapur -= jumlah;
    }

    abstract class Hitungbiaya();
}

class PaketReguler : PaketMBG
{
    string[] isiPaket = ["nasi", "ayam", "sayur", "buah"];
    int harga = 15000;

    abstract class hitungBiaya(int jumlah)
    {
        int paketReguler = jumlah * 15000;
    }
}

class PaketKhusus : PaketMBG
{
    string[] isiPaket = ["nasi", "ayam", "sayur", "buah"];
    int harga = 20000;
    string[] jenisDiet = ["Rendah Gula", "Vegetarian", "Bebas Gluten"];

    abstract class hitungBiaya(int jumlah)
    {
        int paketKhusus = jumlah * 20000;
    }
}

class DapatDistribusikan()
{
    int KirimPaket;

    interface DistribusiMBG
    {
        Sekolah sekolah_tujuan;
        PaketMBG paket_makanan_yang_dikirim;
        int jumlah;
    }

    //halah lupa aku next nya
}

class PengelolaMBG()
{

    string[][] _tambahSekolah;
    string[][] _tambahPaket;

    class void TambahSekolah (Sekolah sekolah)
    {
        //lupa gimana ngisinya :v
        _tambahSekolah[-1][0] = sekolah.idSekolah;
        _tambahSekolah[-1][1] = sekolah.namaSekolah;
        _tambahSekolah[-1][2] = sekolah.jumlahPaketDiterima;
    } 

    class void TambahPaket(PaketMBG paket)
    {
        _tambahSekolah[-1][0] =  paket.idPaket;
        _tambahSekolah[-1][1] = paket.namaPaket;
        _tambahSekolah[-1][2] = paket.stokDapur;
    }

    class void TampilkanDataMBG()
    {
        foreach (string[] sekolah2d in _tambahSekolah)
        {
            foreach (string sekolah in sekolah2d)
            Console.WriteLine(sekolah);
        }

        foreach (string[] paket2d in _tambahPaket)
        {
            foreach (string paket in paket2d)
                Console.WriteLine(paket);
        }
    }

    //hubungan antara class pengelolaMBG dengan sekolah adalah association. karena pengelolaMBG bisa hidup tanpa sekolah dan sekolah bisa hidup tanpa pengelolaMBG. 
    //beda ceritanya ketika pengelolaMBG dengan paketMBG yang berupa aggregation. mereka berdua adalah satu kesatuan, namun masih hidup mandiri
}

class Main
{
    public static void main(string[] args)
    {
        Sekolah sekolah1 = new Sekolah("1", "tadika mesra", 10);
        Sekolah sekolah2 = new Sekolah("2", "tadika sehat", 15);

        PaketMBG mbg = new PaketMBG();

        PaketKhusus pesanan1 = new PaketKhusus();
        mbg.pesanan1.hitungBiaya(1);
    }
}