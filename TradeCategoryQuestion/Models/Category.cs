using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Models
{
    public class Category
    {
        public string Description { get; private set; }
        public List<IRisk> Risks { get; private set; }

        public Category(List<IRisk> risks)
        {
            Risks = risks;            
        }

        public void SetCategoryDescription(Trade trade)
        {
            foreach (var risk in Risks)
            {
                string description = risk.GetDescriptionRisk(trade);

                if (!string.IsNullOrEmpty(description))
                {
                    Description = description;
                    break;
                }
            }
        }
    }
}
