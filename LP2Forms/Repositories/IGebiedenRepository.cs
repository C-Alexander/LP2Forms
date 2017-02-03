using System.Collections.Generic;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    public interface IGebiedenRepository
    {
        ICollection<Gebied> GetAll();
    }
}