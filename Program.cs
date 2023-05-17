using System.Linq;

namespace okolnaSreda
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				SadarjanieIzsledvane contentResearch = 
					new("Air", "17.05", "Bacteries", 20, 15);
				SadarjanieIzsledvane contentResearch2 =
					new("Water", "19.04", "Microbes", 100, 15);
                SadarjanieIzsledvane contentResearch3 =
                    new("Mountains", "21.03", "Animals", 140, 13);

                List<SadarjanieIzsledvane> listFromContent =
                new List<SadarjanieIzsledvane>() { contentResearch, contentResearch2, contentResearch3 };

                listFromContent.Sort();
                Console.WriteLine(listFromContent.Select(x => x.Sadarjanie).Min());
                Console.WriteLine(listFromContent.Select(x => x.Norma).Max());
                listFromContent.ForEach(x => x.Print());

            }
			catch (ArgumentException exception)
			{
				Console.WriteLine($"ArgException: {exception.Message}");
				throw;
			}
        }
    }
}