using System;

class Decoder
{

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Que frase en Crifrado ROT-13 quieres decifrar?");
        char[] Coded = Console.ReadLine();
        char[] Decoded = Coded;
        for (int i = 0; i < Coded.Length; i++)
        {
            char letter = Coded[i];
            if (letter >= 'A' && letter <= 'Z')
            {
                letter = (char)(((letter - 'A' + 13) % 26) + 'A');
            }
            Coded[i] = letter;
        }
        Console.Clear();
        Console.WriteLine("El mensaje Cifrado era: " + Decoded + "\n\n" + "El mensaje Decifrado ahora es: " + Coded);

    }
}
