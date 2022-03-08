using LayeredArchitectureEvaluation.Mvvm4Layer1.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer1.PresentationLogic.API
{
    public interface IPresentationLogic
    {
        IBusinessLogic BusinessLogic { get; }
    }
}