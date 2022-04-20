using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion
{
    internal class Class1
    {
        class ProductControlReport
        {
            public void Run()
            {
                //CONTEXT = ONSHORE ()
                var high = new HighRiskCategory();
                var medium = new MediumRiskCategory();
                var low = new LowRiskCategory();



                var list = new List<ICategoryRule> { high, medium, low };
                //use list....
            }
        }



        class TraderReport
        {
            public void Run()
            {
                //CONTEXT = OFFSHORE
                var high = new HighRiskCategory();
                var medium = new MediumRiskCategory();
                var notCategorized = new NonIdentifiedCategory();

               


                var list = new List<ICategoryRule> { high, medium, notCategorized };
                //use list....
            }
        }



        class AccountingReport
        {
            public void Run()
            {
                //CONTEXT = OFFSHORE
                var high = new HighRiskCategory();
                var medium = new MediumRiskCategory();
                var notCategorized = new NonIdentifiedCategory();



                var list = new List<ICategoryRule> { high, medium, notCategorized };
                //use list....
            }
        }



        class OperationalReport
        {
            public void Run()
            {
                //CONTEXT = OFFSHORE
                var high = new HighRiskCategory();
                var medium = new MediumRiskCategory();
                var notCategorized = new NonIdentifiedCategory();



                var list = new List<ICategoryRule> { high, medium, notCategorized };
                //use list....
            }
        }
    }
}

public interface Onshore
{
    public HighCategory HighCategory { get; set; }
    public MediumCategory MediumCategory { get; set; }
}

public class ContextFactory
{

    //tem como melhorar isso?
    public static List<ICategoryRule> CreateCategories(string context)
    {
        IList<IContextFactory> contexts = new List<IContextFactory>();

        OnshoreFactory on = new OnshoreFactory();
        OffshoreFactory off = new OffshoreFactory();

        contexts.Add(on);
        contexts.Add(off);

        foreach (var item in contexts)
        {
            if (item.CanConstruct == true)
            {
                return item.ConstructCategoriesRules();
            }
        }

      

        //ICategoryRule cateories;
        //if (context == "Onshore")
        //{
        //    cateories.Add(HighRiskCategory);
        //    cateories.Add(MediumRiskCategory);
        //    cateories.Add(LowRiskCategory);                      

        //}
        //else if (context == "Offshore")
        //{
        //    cateories.Add(HighRiskCategory);
        //    cateories.Add(MediumRiskCategory);
        //    cateories.Add(NonIdentifiedCategory);          

        //}

        //return cateories;

    }
}

public interface IContextFactory
{
    IList<ICategoryRoles> ConstructCategoriesRules();
    bool CanConstruct(string context);
}

public class OnshoreFactory : IContextFactory
{
    public IList<ICategoryRoles> ConstructCategoriesRules()
    {
        ICategoryRule cateories;
        
            cateories.Add(HighRiskCategory);
            cateories.Add(MediumRiskCategory);
            cateories.Add(LowRiskCategory);

        return cateories;
    }

    public bool CanConstruct(string context)
    {
        if (context == "Onshore") 
        {
            return true;
        }
        return false;
    }
}


public class OffshoreFactory : IContextFactory
{
    public IList<ICategoryRoles> ConstructCategoriesRules()
    {
        ICategoryRule cateories;

        cateories.Add(HighRiskCategory);
        cateories.Add(MediumRiskCategory);
        cateories.Add(NonIdentifiedCategory);

        return cateories;
    }

    public bool CanConstruct(string context)
    {
        if (context == "Offshore")
        {
            return true;
        }
        return false;
    }
}