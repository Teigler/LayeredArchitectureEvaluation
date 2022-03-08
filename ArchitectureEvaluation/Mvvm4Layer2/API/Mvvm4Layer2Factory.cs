using LayeredArchitectureEvaluation.Mvvm4Layer2.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer2.DataAccess.API;
using LayeredArchitectureEvaluation.Mvvm4Layer2.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer2.API
{
    public class Mvvm4Layer2Factory : IMvvm4Layer2Factory
    {
    

        public IMvvm4Layer2 CreateMvvm4Layer2( )
        {
            IDataAccess dataAccess = new DataAccess.API.DataAccess();
            IBusinessLogic businessLogic = new BusinessLogic.API.BusinessLogic(dataAccess);
            IPresentationLogic presentationLogic = new PresentationLogic.API.PresentationLogic(businessLogic);
            var mvvm4Layer2 = new Mvvm4Layer2(presentationLogic);
            return mvvm4Layer2;
        }
    }
}