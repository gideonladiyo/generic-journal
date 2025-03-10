using System;

class Penjumlahan
{
    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic x = angka1;
        dynamic y = angka2;
        dynamic z = angka3;

        return x + y + z;
    }
}

class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        float hasil = penjumlahan.JumlahTigaAngka(2.2f, 1.1f, 1.0f);
        Console.WriteLine($"Jumlah dari nim 2211104022: {hasil}");
    }
}