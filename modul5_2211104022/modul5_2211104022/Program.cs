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

class SimpleDatabase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDatabase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {storedData[i]}, ditambahkan pada {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        float hasil = penjumlahan.JumlahTigaAngka(2.2f, 1.1f, 1.0f);
        Console.WriteLine($"Jumlah dari nim 2211104022: {hasil}");

        SimpleDatabase<float> database = new SimpleDatabase<float>();
        database.AddNewData(2.2f);
        database.AddNewData(1.1f);
        database.AddNewData(1.0f);
        database.PrintAllData();
    }
}