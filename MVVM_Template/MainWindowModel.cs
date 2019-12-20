using MVVM_Template.Utils.MVVM;
using MVVM_Template.ViewModel;

namespace MVVM_Template
{
    class MainWindowModel : ViewModelBase
    {
        public MainWindowModel()
        {
            ContentView = new MainViewModel();
        }

        // Properties : Propriétés associées aux autres éléments de la vue (Label, TextBox...)
        #region Properties
        // Permet de choisir la vue que l'on affiche.
        // Exemple : Si l'on veut afficher un "MainView", on affecte à ContentView un "MainViewModel"
        public ViewModelBase ContentView
        {
            get { return GetValue(() => ContentView); }
            set { SetValue(() => ContentView, value); }
        }
        #endregion
    }
}
