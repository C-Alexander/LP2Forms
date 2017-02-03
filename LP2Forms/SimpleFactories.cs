//// /// Created by Alexander Vegt in 2017

//using LP2Forms.DomeinModellen;

//namespace LP2Forms
//{
//    public class SimpleFactories //not implementing the factory pattern properly - well aware. Not fully relevant to this application.
//    {
//        public static Gebied GebiedSQLFactory()
//        {
//            var gebiedRepo = GebiedRepoSQLFactory();
//            var gebied = gebiedRepo.GetAll();
//            gen
//        }

//        public static IGebiedenRepository GebiedRepoSQLFactory()
//        {
//            return new GebiedenRepository(GebiedContextSQLFactory());
//        }

//        private static IGebiedenSQLContext GebiedContextSQLFactory()
//        {
//           return new GebiedenSQLContext(new DatabaseConnector());
//        }
//    }
//}