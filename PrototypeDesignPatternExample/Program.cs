using PrototypeDesignPatternExample.Prototype;
using System;

namespace PrototypeDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HorsePicture horsePicture = new HorsePicture();

            horsePicture.Name = "Bryza";
            horsePicture.Race = "Arabska";
            horsePicture.Coat = "Gniada";
            horsePicture.Mane = "Biała";

            IHorsePicture secondHorsePicture = horsePicture.Copy();

            secondHorsePicture.Name = "Błyskawica";
            secondHorsePicture.AdditionalFeatures = "Założona uprząż i siodło";

            Display(horsePicture);
            Display(secondHorsePicture);

            Console.ReadKey();
        }

        static void Display(IHorsePicture horsePicture)
        {
            Console.WriteLine("Imię konia: {0}", horsePicture.Name);
            Console.WriteLine("Rasa: {0}", horsePicture.Race);
            Console.WriteLine("Maść: {0}", horsePicture.Coat);
            Console.WriteLine("Grzywa: {0}", horsePicture.Mane);
            Console.WriteLine("Inne cechy: {0}", horsePicture.AdditionalFeatures);

            Console.WriteLine("===================");
        }
    }
}