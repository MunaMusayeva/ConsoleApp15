class Proqram
{

    public static int Toplama( int x, int y)
    {
        return x + y;
    }
    public static int Cixma(int x, int y)
    {
        return x - y;
    }
    public static int Vurma(int x, int y)
    {
        return x * y;
    }
    public static int Bolme(int x, int y)
    {
        return x / y;
    }
    static void Main(string[] args)
    {
        Func<int, int,int> func = Toplama;
        Console.WriteLine("Seciminizi daxil edin:");
        int secim=int.Parse(Console.ReadLine());
        if (secim == 1)
        {
            func += Toplama;
            Console.WriteLine(func.Invoke(6, 3));
        }
        else if (secim == 2)
        {
            func += Cixma;
            Console.WriteLine(func.Invoke(6, 3));
        }
        else if (secim == 3)
        {
            func += Bolme;
            Console.WriteLine(func.Invoke(6, 3));
        }
        else if (secim == 4)
        {
            func += Vurma;
            Console.WriteLine(func.Invoke(6, 3));
        }
    }
}