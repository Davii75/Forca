string palavrasecreta;
string letra;
bool letraexiste;

Console.WriteLine("--- FORCA ---");
Console.WriteLine();
Console.Write("Qual a palavra secreta? ");
palavrasecreta = Console.ReadLine()!;

Console.WriteLine();
Console.Write("Qual a letra? ");

letra = Console.ReadLine()!
            .Trim()
            .Substring(0, 1)
            .ToLower();

letraexiste = palavrasecreta
                .ToLower()
                .Contains(letra);

Console.WriteLine();
Console.WriteLine($"A letra {letra} existe na palavra secreta? ");
Console.WriteLine($"{letraexiste}!");
