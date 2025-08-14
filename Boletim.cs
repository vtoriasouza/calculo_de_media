
class Boletim
{
    public double CalcularMedia(Notas notas)
    {
        double media = (notas.Nota1 + notas.Nota2 + notas.Nota3) / 3;
        return media;
    }

    public string VerificarSituacao(double media)
    {
        if (media >= 6)
            return "Aprovado";
        else
            return "DP";
    }
}
