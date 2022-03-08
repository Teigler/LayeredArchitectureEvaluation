using LayeredArchitectureEvaluation.Mvvm4Layer2.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer2.PresentationLogic.API
{
    public interface IPresentationLogic
    {
        IBusinessLogic BusinessLogic { get; }
    }
}