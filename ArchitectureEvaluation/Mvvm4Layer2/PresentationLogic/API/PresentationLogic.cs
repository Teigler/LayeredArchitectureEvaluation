using LayeredArchitectureEvaluation.Mvvm4Layer2.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer2.PresentationLogic.API
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
