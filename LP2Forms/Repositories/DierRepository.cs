using System.Collections.Generic;
using LP2Forms.Contexts;
using LP2Forms.DomeinModellen;

namespace LP2Forms.Repositories
{
    internal class DierRepository : IDierRepository
    {
        private IDierSQLContext _context;

        public DierRepository(IDierSQLContext dierSQLContext)
        {
            _context = dierSQLContext;
        }

        public ICollection<Dier> GetAll()
        {
            return _context.GetAll();
        }

        public void BerekenBroedparen()
        {
            _context.BerekenBroedparen();
        }
    }
}