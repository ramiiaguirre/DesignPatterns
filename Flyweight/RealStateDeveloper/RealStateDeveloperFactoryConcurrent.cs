using System.Collections.Concurrent;
using Flyweight;
class RealStateDeveloperFactoryConcurrent
{
    readonly ConcurrentDictionary<CompanyName, RealStateDeveloper> _flyweights = new ConcurrentDictionary<CompanyName, RealStateDeveloper>();

    public RealStateDeveloper Create(CompanyName name)
    {
        return _flyweights.GetOrAdd(name, key =>
        {
            return key switch
            {
                CompanyName.Center =>
                    new RealStateDeveloper(name, "Center RS", 14_585_154.50M, "Av. 7 1547"),
                CompanyName.West =>
                    new RealStateDeveloper(name, "West RS", 3_514_100.12M, "Av. 18 57"),
                CompanyName.GomezEHijos =>
                    new RealStateDeveloper(name, "Gomez E Hijos", 8_054_977.00M, "Av. 8 1742"),
                CompanyName.Cabrera =>
                    new RealStateDeveloper(name, "Cabrera Company", 6_145_896.80M, "Av. 7 1547"),
                _ => throw new ArgumentException($"CompanyName no válido: {key}")
            };
        });
    }
}