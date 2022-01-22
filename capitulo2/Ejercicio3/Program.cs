
float grado, calcular, numero = 1, divisor = 1, aux = 1;

Console.WriteLine("Digite la cantidad en grados ");
grado = float.Parse(Console.ReadLine());

calcular = grado / 180;

while (!(aux == calcular))
{

    aux = numero / divisor;

    if (aux < calcular)
    {
        numero++;
    }
    else
    {
        if (aux > calcular)
        {
            numero--;
            divisor++;
        }
    }
}

Console.WriteLine($"\nEl resultado en radianes es {numero}/{divisor} \n");

