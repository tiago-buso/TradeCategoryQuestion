using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public class Trade : ITrade
    {

        //read-only properties from line number of input file and column index from the third line onwards (ITrade properties)
        public static readonly int ReferenceDateLineNumber = 1;
        public static readonly int NumberOfTradesLineNumber = 2;
        private readonly int ValueColumn = 0;
        private readonly int ClientSectorColumn = 1;
        private readonly int NextPaymentDateColumn = 2;
        private static readonly string DateTimeFormat = "MM/dd/yyyy";

        //Itrade properties
        public double Value {get; private set;}

        public string ClientSector { get; private set; }

        public DateTime NextPaymentDate { get; private set; }

        //Trade properties
        public DateTime ReferenceDate { get; private set; }
        public int NumberOfTrades { get; private set; }      
       

        public Trade(DateTime referenceDate, int numberOfTrades)
        {
            this.ReferenceDate = referenceDate;
            this.NumberOfTrades = numberOfTrades; 
        }
       
        public Trade SetPropertyByText(string textLine)
        {            
            string[] transactionDetails = textLine.Split(' ');

            int index = 0;
            foreach (var detail in transactionDetails)
            {
                SetITradePropertiesByColumnIndex(index, detail);
                index++;
            }           

            return this;
        }

        public void SetITradePropertiesByColumnIndex(int index, string detail)
        {
            if (IsValueColumnLine(index))
            {
                SetValueFromText(detail);
            }
            else if (IsClientSectorColumnLine(index))
            {
                SetClientSectorFromText(detail);
            }
            else if (IsNextPaymentDateColumnLine(index))
            {
                SetNextPaymentDateFromText(detail); 
            }
        }

        public static DateTime GetReferenceDateFromText(string text)
        {
            return DateTime.ParseExact(text, DateTimeFormat, null);
        }

        public static int GetNumberOfTradesFromText(string text)
        {
            return int.Parse(text);
        }

        public bool IsValueColumnLine(int index)
        {
            return ValueColumn == index;    
        }

        public bool IsClientSectorColumnLine(int index)
        {
            return ClientSectorColumn == index;
        }

        public bool IsNextPaymentDateColumnLine(int index)
        {
           return NextPaymentDateColumn == index;   
        }

        //set methods for the ITrade properties
        public void SetValueFromText(string text)
        {
             Value = double.Parse(text);
        }

        public void SetClientSectorFromText(string text)
        {
            ClientSector = text.ToUpper();   
        }

        public void SetNextPaymentDateFromText(string text)
        {
            NextPaymentDate = DateTime.ParseExact(text, DateTimeFormat, null);
        }        
    }
}
