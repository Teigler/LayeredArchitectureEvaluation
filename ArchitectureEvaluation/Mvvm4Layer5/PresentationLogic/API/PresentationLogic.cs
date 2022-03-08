using LayeredArchitectureEvaluation.Mvvm4Layer5.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer5.PresentationLogic.API
{
    internal class PresentationLogic : IPresentationLogic
    {
        public PresentationLogic(IBusinessLogic businessLogic)
        {
            BusinessLogic = businessLogic;
        }

        public IBusinessLogic BusinessLogic { get; private set; }
    }
}
