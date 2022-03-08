using LayeredArchitectureEvaluation.Mvvm4Layer1.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer1.BusinessLogic.API
{
    internal class BusinessLogic : IBusinessLogic
    {

        internal BusinessLogic()
        {
            DataAccess = new DataAccess.API.DataAccess();
        }


        internal IDataAccess DataAccess { get; private set; }

    }
}
