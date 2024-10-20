using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quotes.YeQuotes();

            Console.WriteLine("");

            Quotes.RonsQuotes();
        }
    }
}
