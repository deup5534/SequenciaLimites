Console.Write("\nínicio:");
int numeroInicial = Convert.ToInt32(Console.ReadLine());

Console.Write("\nFim:");
int numeroFinal = Convert.ToInt32(Console.ReadLine());

if (numeroFinal < numeroInicial)
{
    Console.WriteLine("mano... faz isso direito!");
}
else
{
    while (numeroInicial <= numeroFinal)
    {
        Console.Write($"{numeroInicial} ");
        numeroInicial +=1;
    }
}
Console.WriteLine();