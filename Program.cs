double n1, n2, n3, n4, media;
string resultado;

Console.WriteLine("-- Média --\n");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Digite as suas notas abaixo.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Nota 1: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Nota 2: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Nota 3: ");
n3 = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Nota 4: ");
n4 = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

Console.WriteLine();

if (n1 < 0 || n1 > 10
 || n2 < 0 || n2 > 10
 || n3 < 0 || n3 > 10
 || n4 < 0 || n4 > 10)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Console.ResetColor();
}
else
{
    media = (n1 + n2 + n3 + n4) / 4;

    if (media < 5)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        resultado = "Reprovado";
        Console.ResetColor();
    }
    else if (media > 6)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        resultado = "Aprovado";
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        resultado = "Em recuperação";
        Console.ResetColor();
    }
     Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
    Console.ResetColor();
}
