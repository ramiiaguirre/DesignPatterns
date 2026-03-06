using Flyweight;

class RealStateDeveloperFactory
{

    readonly Dictionary<CompanyName, RealStateDeveloper> _flyweights = new Dictionary<CompanyName, RealStateDeveloper>();
    
    public RealStateDeveloper Create(CompanyName name)
    {
       if(!_flyweights.ContainsKey(name))
       {
           switch (name)
           {
               case CompanyName.Center:
                   _flyweights.Add(name, 
                       new RealStateDeveloper(name, "Center RS", 14_585_154.50M, "Av. 7 1547"));
                   break;
               case CompanyName.West:
                   _flyweights.Add(name, 
                       new RealStateDeveloper(name, "West RS", 3_514_100.12M, "Av. 18 57"));
                   break;
               case CompanyName.GomezEHijos:
                   _flyweights.Add(name, 
                       new RealStateDeveloper(name, "Gomez E Hijos", 8_054_977.00M, "Av. 8 1742"));
                   break;
               case CompanyName.Cabrera:
                   _flyweights.Add(name, 
                       new RealStateDeveloper(name, "Cabrera Company", 6_145_896.80M, "Av. 7 1547"));
                   break;
               default:
                   break;
           }
       }

       return _flyweights[name]; 
    }
}