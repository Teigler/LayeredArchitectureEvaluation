using LayeredArchitectureEvaluation.Mvvm4Layer5.API;
using LayeredArchitectureEvaluation.Mvvm4Layer5.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer5.DataAccess.API;
using LayeredArchitectureEvaluation.Mvvm4Layer5.PresentationLogic.API;
using Ninject.Modules;

namespace LayeredArchitectureEvaluation.Mvvm4Layer5.DependencyInjectionContainer
{
    public class Mvvm4Layer5Module : NinjectModule
    {
        public override void Load()
        {
            Bind<IMvvm4Layer5>().To<API.Mvvm4Layer5>();
            Bind<IPresentationLogic>().To<PresentationLogic.API.PresentationLogic>();
            Bind<IBusinessLogic>().To<BusinessLogic.API.BusinessLogic>();
            Bind<IDataAccess>().To<DataAccess.API.DataAccess>();
        }
    }
}