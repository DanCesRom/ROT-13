using System;

class Decoder
{
    
    static string ROT13(string input)
    {
        char[] inputArray = input.ToCharArray();
        for (int i = 0; i < inputArray.Length; i++)
        {
            char letter = input[i];

            if (letter >= 'A' && letter <= 'Z')
            {
                letter = (char)(((letter - 'A' + 13) % 26) + 'A');
            }
            inputArray[i] = letter;
        }

        return new string(inputArray);
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Que frase en Crifrado ROT-13 quieres decifrar?");
        string Code = Console.ReadLine();
        string Decoded = ROT13(Code);
        Console.Clear();
        Console.WriteLine("El mensaje Cifrado era: " + Code + "\n\n" + "El mensaje Decifrado ahora es " + Decoded );
    }
}
