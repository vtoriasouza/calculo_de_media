namespace Aula2;
class Program
{
    static void Main(string[] args)
    {
        Terminal.ApresentarPrograma();

        Notas notas = new Notas();
        Boletim boletim = new Boletim();
        Terminal terminal = new Terminal();

        notas.Nota1 = Terminal.PedirNota("Informe a primeira nota: ");
        notas.Nota2 = Terminal.PedirNota("Informe a segunda nota: ");
        notas.Nota3 = Terminal.PedirNota("Informe a segunda nota: ");

        double media = boletim.CalcularMedia(notas);
        string sit = boletim.VerificarSituacao(media);

        terminal.ApresentarResposta(notas, media, sit);

    }

}
