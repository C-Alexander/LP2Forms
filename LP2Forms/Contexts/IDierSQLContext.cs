using System.Collections.Generic;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Contexts
{
    internal interface IDierSQLContext
    {
        ICollection<Dier> GetAll();
        void BerekenBroedparen();
    }
}