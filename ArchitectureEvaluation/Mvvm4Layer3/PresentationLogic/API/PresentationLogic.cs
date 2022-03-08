using LayeredArchitectureEvaluation.Mvvm4Layer3.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.PresentationLogic.API
{
    internal class PresentationLogic : IPresentationLogic
    {
        internal PresentationLogic(IBusinessLogic businessLogic)
        {
            BusinessLogic = businessLogic;
        }

        public IBusinessLogic BusinessLogic { get; private set; }
    }
}
