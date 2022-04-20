using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public enum RiskEnum
    {
        [Description("EXPIRED")]
        Expired = 0,
        [Description("MEDIUMRISK")]
        Medium = 1,
        [Description("HIGHRISK")]
        High = 2,
        [Description("NOTCLASSIFIED")]
        Not = 3,
    }
}
