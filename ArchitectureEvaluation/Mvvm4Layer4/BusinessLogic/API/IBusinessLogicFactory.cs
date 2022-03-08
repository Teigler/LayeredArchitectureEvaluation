using LayeredArchitectureEvaluation.Mvvm4Layer4.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API
{
    internal interface IBusinessLogicFactory
    {
        IBusinessLogic CreateBusinessLogic(IDataAccess dataAccess);
    }
}