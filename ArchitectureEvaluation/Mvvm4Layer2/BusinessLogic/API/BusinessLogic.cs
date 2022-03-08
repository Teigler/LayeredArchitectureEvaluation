using LayeredArchitectureEvaluation.Mvvm4Layer2.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer2.BusinessLogic.API
{
    internal class BusinessLogic : IBusinessLogic
    {

        internal BusinessLogic(IDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }


        internal IDataAccess DataAccess { get; private set; }

    }
}
