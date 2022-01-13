Main();

static void Main()
{
    Thread t1 = new Thread(ThreadRepeticao);
    t1.Start();

    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Main: " + i);
    }

    Console.ReadKey();
}


static void ThreadRepeticao()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("Num: " + i);
    }
}