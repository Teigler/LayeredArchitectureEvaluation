using LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.PresentationLogic.API
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
