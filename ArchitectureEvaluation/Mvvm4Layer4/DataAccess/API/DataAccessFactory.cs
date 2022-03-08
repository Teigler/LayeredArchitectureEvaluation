
namespace LayeredArchitectureEvaluation.Mvvm4Layer4.DataAccess.API
{
    internal class DataAccessFactory : IDataAccessFactory
    {
       

        public IDataAccess CreateDataAccess()
        {
            return new DataAccess();
        }
    }
}