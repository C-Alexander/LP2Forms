using System.Collections.Generic;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Contexts
{
    public interface IGebiedenSQLContext
    {
        ICollection<Gebied> GetAll();
    }
}