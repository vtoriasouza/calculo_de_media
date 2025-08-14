
class Terminal
{
    public static void ApresentarPrograma()
    {
        Console.WriteLine("-- PROGRAMA DA MÉDIA --");
        Console.WriteLine("-----------------------");
    }

    public void ApresentarResposta(Notas notas, double media, string situacao)
    {
        Console.WriteLine("-- BOLETIM --");
        Console.WriteLine($"Notas: {notas.Nota1}, {notas.Nota2}, {notas.Nota3}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Situação: {situacao}");
    }

    public static double PedirNota(string msg)
    {
        Console.WriteLine(msg);
        return Convert.ToDouble(Console.ReadLine());
    }
}