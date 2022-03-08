using LayeredArchitectureEvaluation.Mvvm4Layer1.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer1.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer1.API
{
    internal class Mvvm4Layer1 : IMvvm4Layer1
    {

        internal Mvvm4Layer1(IPresentationLogic presentationLogic)
        {
            PresentationLogic = presentationLogic;
            BusinessLogic = PresentationLogic.BusinessLogic;
        }


        internal IBusinessLogic BusinessLogic { get; private set; }
        internal IPresentationLogic PresentationLogic { get; private set; }


    }
}