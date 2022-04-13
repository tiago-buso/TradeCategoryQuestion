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
        public List<Trade> GetTradesFromInput(string path)
        {
            List<Trade> trades = new List<Trade>(); 
            string text = string.Empty;
            Trade trade = new Trade();

            using (StreamReader file = new StreamReader(path))
            {
                int lineNumber = 1;
                string textLine = String.Empty;

                while ((textLine = file.ReadLine()) != null)
                {
                    trade = trade.SetPropertyByLineNumber(lineNumber, textLine);
                    lineNumber++;
                }
                file.Close();                
            }

            return trades;
        }        
    }
}
