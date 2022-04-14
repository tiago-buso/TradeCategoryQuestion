using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public class RiskFactory
    {
        public static IRisk Create(RiskEnum riskEnum)
        {
            switch (riskEnum)
            {
                case RiskEnum.Expired:
                    return new ExpiredRisk();
                case RiskEnum.Medium:
                    return new MediumRisk();
                case RiskEnum.High:
                    return new HighRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
