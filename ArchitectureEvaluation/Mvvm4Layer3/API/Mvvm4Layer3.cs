using LayeredArchitectureEvaluation.Mvvm4Layer3.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer3.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.API
{
    internal class Mvvm4Layer3 : IMvvm4Layer3
    {

        internal Mvvm4Layer3(IPresentationLogic presentationLogic)
        {
            PresentationLogic = presentationLogic;
            BusinessLogic = PresentationLogic.BusinessLogic;
        }


        internal IPresentationLogic PresentationLogic { get; private set; }

        internal IBusinessLogic BusinessLogic { get; private set; }


    }
}