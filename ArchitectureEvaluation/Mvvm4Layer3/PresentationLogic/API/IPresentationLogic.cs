using LayeredArchitectureEvaluation.Mvvm4Layer3.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.PresentationLogic.API
{
    public interface IPresentationLogic
    {
        IBusinessLogic BusinessLogic { get; }
    }
}