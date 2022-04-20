using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    internal class NotClassified : IRisk
    {
        public string GetDescriptionRisk(Trade trade)
        {
            return "Not classified";
        }
    }
}
