internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el multiplicador: ");
        int multiplicador = Int32.Parse(Console.ReadLine());
        Console.Write("Ingrese el multiplicando: ");
        int multiplicando = Int32.Parse(Console.ReadLine());
        int resultado = 0;
        do
        {
            if (multiplicador % 2 != 0)
            {
                resultado += multiplicando;
            }
            multiplicador /= 2;
            multiplicando *= 2;
        } while (multiplicador > 1);
        resultado += multiplicando;
        Console.WriteLine($"Resultado: {resultado}");
    }
}