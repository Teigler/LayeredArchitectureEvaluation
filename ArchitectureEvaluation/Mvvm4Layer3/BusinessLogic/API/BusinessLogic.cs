using LayeredArchitectureEvaluation.Mvvm4Layer3.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.BusinessLogic.API
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
