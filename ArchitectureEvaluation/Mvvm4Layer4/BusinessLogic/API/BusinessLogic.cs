using LayeredArchitectureEvaluation.Mvvm4Layer4.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API
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
