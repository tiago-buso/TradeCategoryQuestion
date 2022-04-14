using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public interface IRisk
    {
        string GetDescriptionRisk(Trade trade);
    }
}
