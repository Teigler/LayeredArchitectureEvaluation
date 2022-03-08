using LayeredArchitectureEvaluation.Mvvm4Layer5.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer5.PresentationLogic.API
{
    public interface IPresentationLogic
    {
        IBusinessLogic BusinessLogic { get; }
    }
}