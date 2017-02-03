using System.Collections.Generic;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    public class GebiedenRepository : IGebiedenRepository
    {
        private IGebiedenSQLContext _context;

        public GebiedenRepository(IGebiedenSQLContext context)
        {
            _context = context;
        }

        public ICollection<Gebied> GetAll()
        {
            return _context.GetAll();
        }
    }
}