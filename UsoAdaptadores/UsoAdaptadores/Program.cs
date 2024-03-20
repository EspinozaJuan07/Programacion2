//Ejemplo de escritura y lectura de datos de un archivo de texto

string texto = "Ejemplo de texto";
File.WriteAllText("texto.txt", texto);

//Leer datos desde un archivo de texto
string texto2 = File.ReadAllText("texto.txt");
Console.WriteLine($"Texto leido desde el archivo: {texto2}");

//Escribri datos en un archivo binario
int[] numeros = { 1, 2, 3, 4, 5 };
using(BinaryWriter br = new BinaryWriter(File.Open("numeros.bin", FileMode.Create)))
foreach (int num in numeros)
        br.Write(num);

//Leer datos desde un archivo binario
int[] numerosleidos;

using(BinaryReader bre = new BinaryReader(File.Open("numeros.bin", FileMode.Open)))
{
    numerosleidos = new int[5];
    for (int i = 0; i < numerosleidos.Length; i++)
           numerosleidos[i] = bre.ReadInt32();
}

Console.WriteLine("Numero leidos desde el archivo binario");
foreach(int num in numerosleidos)
    Console.WriteLine(num);

