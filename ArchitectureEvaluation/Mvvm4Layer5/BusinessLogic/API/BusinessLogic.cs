using LayeredArchitectureEvaluation.Mvvm4Layer5.DataAccess.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer5.BusinessLogic.API
{
    internal class BusinessLogic : IBusinessLogic, Mvvm4Layer4.BusinessLogic.API.IBusinessLogic
    {

        public BusinessLogic(IDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }


        internal IDataAccess DataAccess { get; private set; }

    }
}
