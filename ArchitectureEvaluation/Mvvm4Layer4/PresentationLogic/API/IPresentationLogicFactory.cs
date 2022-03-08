using LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.PresentationLogic.API
{
    internal interface IPresentationLogicFactory
    {
        IPresentationLogic CreatePresentationLogic(IBusinessLogic businessLogic);
    }
}