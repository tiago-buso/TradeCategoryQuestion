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

            List<Trade> trades = GetTradeFromInputTextLines(lines);    

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
        
        private List<Trade> GetTradeFromInputTextLines(Dictionary<int, string> inputTextLines)
        {
            List<Trade> trades = new List<Trade>();            

            DateTime referenceDate = Trade.GetReferenceDateFromText(inputTextLines.First(x => x.Key == Trade.ReferenceDateLineNumber).Value);
            int numberOfTrades = Trade.GetNumberOfTradesFromText(inputTextLines.First(x => x.Key == Trade.NumberOfTradesLineNumber).Value);

            IEnumerable<string> remainingLines = inputTextLines.Where(x => x.Key != Trade.NumberOfTradesLineNumber && x.Key != Trade.ReferenceDateLineNumber).ToList().Select(x => x.Value);

            foreach (var line in remainingLines)
            {
                Trade trade = new Trade(referenceDate, numberOfTrades);
                trade = trade.SetPropertyByText(line);
                
                trades.Add(trade);
            }

            return trades;
        }
    }
}
