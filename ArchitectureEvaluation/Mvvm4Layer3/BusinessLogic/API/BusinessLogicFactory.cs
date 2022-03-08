using LayeredArchitectureEvaluation.Mvvm4Layer3.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.BusinessLogic.API
{
    internal class BusinessLogicFactory : IBusinessLogicFactory
    {
        internal BusinessLogicFactory()
        {
            DataAccessFactory = new DataAccessFactory();
        }


        /// <summary>
        /// Testable Constructor
        /// </summary>
        internal BusinessLogicFactory(IDataAccessFactory dataAccessFactory)
        {
            DataAccessFactory = dataAccessFactory;
        }

        public IBusinessLogic CreateBusinessLogic()
        {
            IDataAccess dataAccess = DataAccessFactory.CreateDataAccess();
            return new BusinessLogic(dataAccess);
        }


        private IDataAccessFactory DataAccessFactory { get; set; }
    }
}