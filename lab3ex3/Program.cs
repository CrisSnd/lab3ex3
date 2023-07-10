namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul*/

            Console.WriteLine("Introduceti numarul: ");
            int numarIntrodus = int.Parse(Console.ReadLine());

            bool resultatReturnat = VerificarePatratPerfect(numarIntrodus);
            if (resultatReturnat == true)
            {
                Console.WriteLine("\n" + "Numarul {0} este patrat perfect.", numarIntrodus);
            }
            else
            {
                Console.WriteLine("\n" + "Numarul {0} nu este patrat perfect.", numarIntrodus);
            }

        }
        static bool VerificarePatratPerfect(int numarIntrodus)
        {
            for (int i = 1; i <= numarIntrodus / 2; i++)
            {
                if (i * i == numarIntrodus)
                {
                    return true;
                }

            }

            return false;

        }

    }
}
