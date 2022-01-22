

int suma = 0;
int Lado = 0;
int N = 0;
Console.WriteLine("Digite la cantida de lado de su poligono");
N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"\nDigite el {i} lado de su figura");
    Lado = int.Parse(Console.ReadLine());

    suma = Lado + suma;



}

Console.WriteLine("\nEl resultado es: " + suma + "\n");
