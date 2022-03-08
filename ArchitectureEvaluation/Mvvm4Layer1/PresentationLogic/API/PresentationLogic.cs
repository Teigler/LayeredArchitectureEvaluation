using LayeredArchitectureEvaluation.Mvvm4Layer1.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer1.PresentationLogic.API
{
    internal class PresentationLogic : IPresentationLogic
    {
        internal PresentationLogic()
        {
            BusinessLogic = new BusinessLogic.API.BusinessLogic();
        }

        public IBusinessLogic BusinessLogic { get; private set; }
    }
}
