using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategoryQuestion.Models;

namespace TradeCategoryQuestion.Services
{
    public class InputService 
    {
        public List<string> GetCategoriesFromFile(string path)
        {
            Dictionary<int, string> lines = GetLinesFromInput(path);

            Trade trade = GetTradeFromInputTextLines(lines);    

            return new List<string>();
        }
        
        private Dictionary<int, string> GetLinesFromInput(string path)
        {            
            Dictionary<int, string> lines = new Dictionary<int, string>();  

            using (StreamReader file = new StreamReader(path))
            {
                int lineNumber = 1;
                string textLine = String.Empty;

                while ((textLine = file.ReadLine()) != null)
                {
                    lines.Add(lineNumber, textLine);
                    lineNumber++;
                }
                file.Close();                
            }

            return lines;
        }
        
        private Trade GetTradeFromInputTextLines(Dictionary<int, string> inputTextLines)
        {
            Trade trade = new Trade();
            foreach (var line in inputTextLines)
            {
                trade = trade.SetPropertyByLineNumber(line.Key, line.Value);
            }

            return trade;
        }
    }
}
