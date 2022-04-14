using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategoryQuestion.Utilities;

namespace TradeCategoryQuestion.Models
{
    public class ExpiredRisk : IRisk
    {
        public string GetDescriptionRisk(Trade trade)
        {
            string descricao = string.Empty;

            if (trade.NextPaymentDate.AddDays(30) < trade.ReferenceDate)
            {
                descricao = Utility.GetDescriptionFromEnumValue(RiskEnum.Expired);
            }

            return descricao;
        }
    }
}
