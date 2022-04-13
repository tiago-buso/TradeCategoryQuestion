using TradeCategoryQuestion.Services;

namespace TradeCategoryQuestion.Models
{
    public class Program
    {       
        static void Main(string[] args)
        {
            InputService inputService = new InputService();

            string path = $"{Directory.GetCurrentDirectory()}\\Input\\Input.txt";          

            List<string> categories = inputService.GetCategoriesFromFile(path);
        }
    }
}