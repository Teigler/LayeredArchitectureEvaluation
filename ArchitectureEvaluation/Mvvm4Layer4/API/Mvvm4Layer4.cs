using LayeredArchitectureEvaluation.Mvvm4Layer4.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer4.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer4.API
{
    internal class Mvvm4Layer4 : IMvvm4Layer4
    {

        internal Mvvm4Layer4(IPresentationLogic presentationLogic)
        {
            PresentationLogic = presentationLogic;
            BusinessLogic = presentationLogic.BusinessLogic;

        }


        internal IPresentationLogic PresentationLogic { get; private set; }

        internal IBusinessLogic BusinessLogic { get; private set; }


    }
}