using LayeredArchitectureEvaluation.Mvvm4Layer3.PresentationLogic.API;

namespace LayeredArchitectureEvaluation.Mvvm4Layer3.API
{
    public class Mvvm4Layer3Factory : IMvvm4Layer3Factory
    {

        public Mvvm4Layer3Factory()
        {
            PresentationLogicFactory = new PresentationLogicFactory();
        }

        /// <summary>
        /// Testable Constructor
        /// </summary>
        internal Mvvm4Layer3Factory(IPresentationLogicFactory presentationLogicFactory)
        {
            PresentationLogicFactory = presentationLogicFactory;
        }


  

        public IMvvm4Layer3 CreateMvvm4Layer3( )
        {
            var presentationLogic = PresentationLogicFactory.CreatePresentationLogic();
            var mvvm4Layer3 = new Mvvm4Layer3(presentationLogic);
            return mvvm4Layer3;
        }


        private IPresentationLogicFactory PresentationLogicFactory { get; set; }

    }
}