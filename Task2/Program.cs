namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            string filePath = @"D:\Загрузки\Text1.txt";
            string allText = File.ReadAllText(filePath);
            var noPunctuationText = new string(allText.Where(c => !char.IsPunctuation(c)).ToArray());
            
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> text = new Dictionary<string, int>();

            
            for (int i = 0; i < words.Length; i++)
            {
                if (text.ContainsKey(words[i]))
                {
                    text[words[i]] += 1;
                }
                else
                    text[words[i]] = 1;
            }

            text = text.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            size = text.Count;

            Console.WriteLine("Десять слов, которые чаще всего встречаются в тексте: ");
            foreach (var word in text)
            {
                if(size < 10) 
                {
                    Console.WriteLine(word.Key + " - " + word.Value + " раз");
                }
                size--;
                
            }
        }
    }
}