using(Stream fs = new FileStream("Clientes.txt",FileMode.Open,FileAccess.Read))
{
    long cantidad = fs.Length;
    Console.WriteLine($"El archivo tiene una " + $"longitud de {cantidad} bytes");

    for(long count = 0; count < cantidad; count++)
    {
        fs.Seek(0, SeekOrigin.Begin);
        int valor = fs.ReadByte();
        Console.WriteLine($"Posicion {count}; {(char)valor}");
    }

    Console.WriteLine("-------------------------");

    for(long count = cantidad;count > 0; count--)
    {
        fs.Seek(-count, SeekOrigin.End);
        int valor = fs.ReadByte();
        Console.WriteLine($"Posicion {count}: {(char)valor}");
    }

    using(StreamReader sr = new StreamReader(fs))
    {
        while(!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine());

            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);
        }
    }
}
