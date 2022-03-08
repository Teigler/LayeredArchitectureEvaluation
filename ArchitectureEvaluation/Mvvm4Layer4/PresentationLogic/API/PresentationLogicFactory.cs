using LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.PresentationLogic.API
{
    internal class PresentationLogicFactory : IPresentationLogicFactory
    {


        public IPresentationLogic CreatePresentationLogic(IBusinessLogic businessLogic)
        {
            return new PresentationLogic(businessLogic);
        }
     

    }
}