using LP2Forms.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP2FormsTests.Repositories
{
    [TestClass()]
    public class GebiedenRepositoryTests
    {


        [TestMethod()]
        public void GetAllTest()
        {
            GebiedenRepositoryFactory().GetAll();
        }

        public GebiedenRepository GebiedenRepositoryFactory()
        {
            return new GebiedenRepository(new MemoryGebiedenContext());
        }
    }
}