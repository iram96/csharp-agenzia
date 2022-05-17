// See https://aka.ms/new-console-template for more information

namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appartamento appartamento = new Appartamento("CIAO123", "via Rossi n20", "1000", "ROMA", 200, 3, 2);

            Villa v = new Villa("CIAO123", "via Carli n10", "2000", "MILANO", 200, 3, 2, 100);

            Agenzia prova = new Agenzia("Mia Agenzia");

            //Console.WriteLine(appartamento.ToString());
            //Console.WriteLine(v.ToString());

            List<Immobile> result = prova.SearchImmobili("c");

            foreach (Immobile i in result)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("--------------------------------------");
            }

        }
    }
}