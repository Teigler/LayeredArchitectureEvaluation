using LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer4.DataAccess.API;
using LayeredArchitectureEvaluation.Mvvm4Layer4.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.API
{
    public class Mvvm4Layer4Factory : IMvvm4Layer4Factory
    {

        public Mvvm4Layer4Factory()
        {
            PresentationLogicFactory = new PresentationLogicFactory();
            BusinessLogicFactory = new BusinessLogicFactory();
            DataAccessFactory = new DataAccessFactory();
        }

        /// <summary>
        /// Testable Constructor
        /// </summary>
        internal Mvvm4Layer4Factory(
            IPresentationLogicFactory presentationLogicFactory,
            IBusinessLogicFactory businessLogicFactory,
            IDataAccessFactory dataAccessFactory)
        {
            PresentationLogicFactory = presentationLogicFactory;
            BusinessLogicFactory = businessLogicFactory;
            DataAccessFactory = dataAccessFactory;
        }



        public IMvvm4Layer4 CreateMvvm4Layer4()
        {
            var dataAccess = DataAccessFactory.CreateDataAccess();
            var businessLogic = BusinessLogicFactory.CreateBusinessLogic(dataAccess);
            var presentationLogic = PresentationLogicFactory.CreatePresentationLogic(businessLogic);
            var mvvm4Layer4 = new Mvvm4Layer4(presentationLogic);
            return mvvm4Layer4;
        }


        private IPresentationLogicFactory PresentationLogicFactory { get; set; }
        private IBusinessLogicFactory BusinessLogicFactory { get; set;}
        private IDataAccessFactory DataAccessFactory { get; set; }
    }
}