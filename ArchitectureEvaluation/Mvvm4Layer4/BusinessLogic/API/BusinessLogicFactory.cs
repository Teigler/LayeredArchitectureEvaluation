
using LayeredArchitectureEvaluation.Mvvm4Layer4.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API
{
    internal class BusinessLogicFactory : IBusinessLogicFactory
    {
  
        public IBusinessLogic CreateBusinessLogic(IDataAccess dataAccess)
        {
            return new BusinessLogic(dataAccess);
        }

    }
}