namespace PigLatinTranslator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to translate: ");
            string stringToTranslate = Console.ReadLine();

            Console.WriteLine("Translated into Pig Latin: {0}", PigLatin.Translate(stringToTranslate));
            Console.WriteLine("The program execution has completed - press any key to exit.");
            Console.ReadKey(); 
        }
    }
}