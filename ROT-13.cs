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
        string mensajeCifrado = "GUR DHVPX OEBJA QBT WHZCRQ BIRE GUR YNML SBK.";
        string mensajeDescifrado = ROT13(mensajeCifrado);
        
        Console.WriteLine("El mensaje Cifrado era: " + mensajeCifrado);
        Console.WriteLine("El mensaje Decifrado ahora es " + mensajeDescifrado);
    }

}
