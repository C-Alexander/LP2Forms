using System.Collections.Generic;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    internal interface IDierRepository
    {
        ICollection<Dier> GetAll();
        void BerekenBroedparen();
    }
}