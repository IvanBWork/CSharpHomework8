namespace CSharpHomework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            FileWorker.FindFiles("D:\\GeekBrains\\C#", "*.txt", list);

            if (args.Length == 1)
            {
                foreach (string file in list)
                {
                    if (FileWorker.FindWord(file, args[0]) == true)
                    {
                        Console.WriteLine(file);
                    }
                }
            }
            else
            {
                Console.Write("Укажите искомое слово: ");
                string text = Console.ReadLine()!;

                foreach (string file in list)
                {
                    if (FileWorker.FindWord(file, text) == true)
                    {
                        Console.WriteLine(file);
                    }
                }
            }
        }
    }
}
