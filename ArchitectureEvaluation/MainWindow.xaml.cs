using System.Windows;
using LayeredArchitectureEvaluation.Mvvm4Layer1.API;
using LayeredArchitectureEvaluation.Mvvm4Layer2.API;
using LayeredArchitectureEvaluation.Mvvm4Layer3.API;
using LayeredArchitectureEvaluation.Mvvm4Layer4.API;
using LayeredArchitectureEvaluation.Mvvm4Layer5.API;
using LayeredArchitectureEvaluation.Mvvm4Layer5.DependencyInjectionContainer;
using Ninject;

namespace LayeredArchitectureEvaluation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            CreateMvvm4Layer1();
            CreateMvvm4Layer2();
            CreateMvvm4Layer3();
            CreateMvvm4Layer4();
            CreateMvvm4Layer5();
        }

        private void CreateMvvm4Layer1()
        {
            IMvvm4Layer1Factory factory = new Mvvm4Layer1Factory();
            Mvvm4Layer1 = factory.CreateMvvm4Layer1();
        }

        private void CreateMvvm4Layer2()
        {
            IMvvm4Layer2Factory factory = new Mvvm4Layer2Factory();
            Mvvm4Layer2 = factory.CreateMvvm4Layer2();
        }

        private void CreateMvvm4Layer3()
        {
            IMvvm4Layer3Factory factory = new Mvvm4Layer3Factory();
            Mvvm4Layer3 = factory.CreateMvvm4Layer3();
        }


        private void CreateMvvm4Layer4()
        {
            IMvvm4Layer4Factory factory = new Mvvm4Layer4Factory();
            Mvvm4Layer4 = factory.CreateMvvm4Layer4();
        }

        private void CreateMvvm4Layer5()
        {
            IKernel kernel = new StandardKernel(new Mvvm4Layer5Module());
            Mvvm4Layer5 = kernel.Get<Mvvm4Layer5.API.Mvvm4Layer5>();
        }




        public IMvvm4Layer1 Mvvm4Layer1 { get; set; }
        public IMvvm4Layer2 Mvvm4Layer2 { get; set; }
        public IMvvm4Layer3 Mvvm4Layer3 { get; set; }
        public IMvvm4Layer4 Mvvm4Layer4 { get; set; }
        public IMvvm4Layer5 Mvvm4Layer5 { get; set; }
    }
}
