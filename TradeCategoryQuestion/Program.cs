using TradeCategoryQuestion.Services;

namespace TradeCategoryQuestion.Models
{
    public class Program
    {       
        static void Main(string[] args)
        {
            InputService inputService = new InputService();

            string path = $"{Directory.GetCurrentDirectory()}\\Input\\Input.txt";          

            List<string> categoriesDescription = inputService.GetCategoriesDescriptionFromFile(path);

            foreach (var description in categoriesDescription)
            {
                Console.WriteLine(description);
            }

            Console.ReadLine();
        }
    }
}