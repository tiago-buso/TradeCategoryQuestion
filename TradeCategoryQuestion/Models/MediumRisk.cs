using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategoryQuestion.Utilities;

namespace TradeCategoryQuestion.Models
{
    public class MediumRisk : IRisk
    {
        public string GetDescriptionRisk(Trade trade)
        {
            string descricao = string.Empty;

            if (trade.ClientSector == Utility.GetDescriptionFromEnumValue(SectorEnum.Public) && trade.Value > 1000000)
            {
                descricao = Utility.GetDescriptionFromEnumValue(RiskEnum.Medium);
            }

            return descricao;
        }
    }
}
