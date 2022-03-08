using LayeredArchitectureEvaluation.Mvvm4Layer2.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer2.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer2.API
{
    internal class Mvvm4Layer2 : IMvvm4Layer2
    {

        internal Mvvm4Layer2(IPresentationLogic presentationLogic)
        {
            PresentationLogic = presentationLogic;
            BusinessLogic = PresentationLogic.BusinessLogic;
        }


        internal IBusinessLogic BusinessLogic { get; private set; }
        internal IPresentationLogic PresentationLogic { get; private set; }


    }
}