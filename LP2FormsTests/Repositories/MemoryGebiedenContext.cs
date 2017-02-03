using System.Collections.Generic;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;

namespace LP2FormsTests.Repositories
{
    internal class MemoryGebiedenContext : IGebiedenSQLContext
    {
        List<Gebied> _gebiedenLijst = new List<Gebied>();
        public ICollection<Gebied> GetAll()
        {
            return _gebiedenLijst;
        }
    }
}