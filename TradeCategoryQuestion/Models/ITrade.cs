using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public interface ITrade
    {
        double Value { get;  } 
        string ClientSector { get;  } 
        DateTime NextPaymentDate { get;  }

        bool IsValueColumnLine(int index);
        bool IsClientSectorColumnLine(int index);
        bool IsNextPaymentDateColumnLine(int index);

        void SetValueFromText(string text);
        void SetClientSectorFromText(string text);
        void SetNextPaymentDateFromText(string text);

        void SetITradePropertiesByColumnIndex(int index, string detail);
    }
}
