using System.Xml;

int glicemia;
string diagnostico;
ConsoleColor corExibicao;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Glicemia (em mg/dL)...: ");
glicemia = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

if (glicemia > 126)
{
    diagnostico = "Diabetes Mellitus na gravidez";
    corExibicao = ConsoleColor.Red;
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "Compatível com Diabetes Gestacional";
        corExibicao = ConsoleColor.Green;
    }
    else
    {
        diagnostico = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
        corExibicao = ConsoleColor.Yellow;
    }
}

Console.ForegroundColor = corExibicao;
Console.WriteLine();
Console.WriteLine(diagnostico);
Console.ResetColor();
