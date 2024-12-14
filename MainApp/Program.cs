using System;

List<string> lista = [];

Random random = new();

Console.WriteLine("Skriv in saker du vill ha gjort och sedan slumpar jag! (För avsluta, skriv: Stopp)\n");

while (true)
{
    string? innerinput = Console.ReadLine();

    if (innerinput == "stopp" || innerinput == null)
    {
        Console.Clear();
        break;
    }
    else
    {
        lista.Add(innerinput!);
        Console.WriteLine($"Inmatningen: {innerinput} är inlagd.\n");
    }
}

// Hämtat från ChatGPT hur random fungerar
int index = random.Next(lista.Count);
// Slumpen väljs av inmatade alternativ - bugg om man skriver in "stopp" som ett alternativ i början
string slumpen = lista[index];

Console.WriteLine("-------------- Jag har valt ett slumpmässigt alternativ --------------");

Console.WriteLine(slumpen);

Console.ReadKey();