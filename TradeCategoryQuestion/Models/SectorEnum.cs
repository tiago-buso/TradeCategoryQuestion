using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public enum SectorEnum 
    {
        [Description("PRIVATE")]
        Private = 0,
        [Description("PUBLIC")]
        Public = 1
    }
}
