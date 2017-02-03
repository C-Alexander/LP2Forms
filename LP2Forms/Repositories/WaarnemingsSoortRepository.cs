using System.Collections.Generic;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    internal class WaarnemingsSoortRepository
    {
        private WaarnemingsSoortSQLContext _context;

        public WaarnemingsSoortRepository(WaarnemingsSoortSQLContext waarnemingsSoortSQLContext)
        {
            _context = waarnemingsSoortSQLContext;
        }

        public ICollection<WaarnemingsSoort> GetAll()
        {
            return _context.GetAll();
        }
    }
}