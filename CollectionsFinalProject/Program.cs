using System.Diagnostics;

namespace Task1
{
    internal class Program
    {
        public const string filePath = "Text1.txt";
        static void Main(string[] args)
        {
            string allText = File.ReadAllText(filePath);
            

            List<string> text = new List<string>();
            LinkedList<string> linkedText = new LinkedList<string>();

            //Вставка текста в List<string>
            var watchTwo = Stopwatch.StartNew();
            text.Add(allText);


            //Вставка текста в LinkedList<string>
            //var watchTwo = Stopwatch.StartNew();
            //linkedText.AddLast(allText);

            watchTwo.Stop();
            Console.WriteLine($"Вставка текста в список: {watchTwo.Elapsed.TotalMilliseconds}  мс");

            //0,0248мс в ListLinked<string>
            //0,0066мс в  List<string>
            //Следовательно, вставка текста в List<>, занимает примерно в 3 раза меньше времени, чем в ListLinked<>.

        }


    }
}