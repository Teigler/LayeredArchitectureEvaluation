
namespace LayeredArchitectureEvaluation.Mvvm4Layer3.DataAccess.API
{
    internal class DataAccessFactory : IDataAccessFactory
    {
       

        public IDataAccess CreateDataAccess()
        {
            return new DataAccess();
        }
    }
}