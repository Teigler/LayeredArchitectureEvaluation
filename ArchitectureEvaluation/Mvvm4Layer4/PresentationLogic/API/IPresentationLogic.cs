using LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.PresentationLogic.API
{
    public interface IPresentationLogic
    {
        IBusinessLogic BusinessLogic { get; }
    }
}