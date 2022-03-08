using LayeredArchitectureEvaluation.Mvvm4Layer5.BusinessLogic.API;
using LayeredArchitectureEvaluation.Mvvm4Layer5.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer5.API
{
    internal class Mvvm4Layer5 : IMvvm4Layer5
    {

        public Mvvm4Layer5(IPresentationLogic presentationLogic)
        {
            PresentationLogic = presentationLogic;
            BusinessLogic = presentationLogic.BusinessLogic;
        }


        internal IPresentationLogic PresentationLogic { get; private set; }

        internal IBusinessLogic BusinessLogic { get; private set; }


    }
}