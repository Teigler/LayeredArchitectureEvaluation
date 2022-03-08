using LayeredArchitectureEvaluation.Mvvm4Layer3.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.PresentationLogic.API
{
    internal class PresentationLogicFactory : IPresentationLogicFactory
    {

        internal PresentationLogicFactory()
        {
            BusinessLogicFactory = new BusinessLogicFactory();
        }

        /// <summary>
        /// Testable Constructor
        /// </summary>
        internal PresentationLogicFactory(IBusinessLogicFactory businessLogicFactory)
        {
            BusinessLogicFactory = businessLogicFactory;
        }


        public IPresentationLogic CreatePresentationLogic()
        {
            IBusinessLogic businessLogic = BusinessLogicFactory.CreateBusinessLogic();
            return new PresentationLogic(businessLogic);
        }


        private IBusinessLogicFactory BusinessLogicFactory { get; set; }

    }
}