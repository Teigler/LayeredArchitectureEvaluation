using LayeredArchitectureEvaluation.Mvvm4Layer1.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer1.API
{
    public class Mvvm4Layer1Factory : IMvvm4Layer1Factory
    {


     
        public IMvvm4Layer1 CreateMvvm4Layer1( )
        {
            IPresentationLogic presentationLogic = new PresentationLogic.API.PresentationLogic();
            var mvvm4Layer1 = new Mvvm4Layer1(presentationLogic);
            return mvvm4Layer1;
        }

    }
}