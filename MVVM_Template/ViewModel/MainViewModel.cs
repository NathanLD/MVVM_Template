using MVVM_Template.Model.POCO;
using MVVM_Template.Utils.MVVM;
using MVVM_Template.Utils.Repository;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Linq;

namespace MVVM_Template.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            // Initialisation des listes et propriétés
            ExampleProperty = "TEST_1";
            ExampleList = new ObservableCollection<string>();
            ExampleList2 = new ObservableCollection<ExampleObject>();
            ExampleVisibility = true;
        }

        // Repositories : Classes où sont stockées les requêtes BDD
        #region Repositories
        ExampleRepository repo = new ExampleRepository();
        #endregion

        // Lists : Collections d'objets associées aux DataGrid, ListBox, ComboBox, ...
        #region Lists
        public ObservableCollection<string> ExampleList
        {
            get { return GetValue(() => ExampleList); }
            set { SetValue(() => ExampleList, value); }
        }

        public ObservableCollection<ExampleObject> ExampleList2
        {
            get { return GetValue(() => ExampleList2); }
            set { SetValue(() => ExampleList2, value); }
        }
        #endregion

        // Properties : Propriétés associées aux autres éléments de la vue (Label, TextBox...)
        #region Properties
        public string ExampleProperty
        {
            get { return GetValue(() => ExampleProperty); }
            set { SetValue(() => ExampleProperty, value); }
        }

        public bool ExampleVisibility
        {
            get { return GetValue(() => ExampleVisibility); }
            set { SetValue(() => ExampleVisibility, value); }
        }
        #endregion

        // Commands : Fonctions associées aux boutons et autres déclencheurs de la vue
        #region Commands
        public ICommand ExampleCommand
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ExampleProperty = ExampleProperty.Equals("TEST_1") ? "TEST_2" : "TEST_1";
                    ExampleList.Add($"Texte modifié en {ExampleProperty}");
                    ExampleList2.Add(new ExampleObject(getNextID(), $"Texte modifié en {ExampleProperty}"));
                    toggleVisibility();
                    MessageBox.Show("Texte modifié !");
                });
            }
        }
        #endregion

        // Methods : Autres fonctions
        #region Methods
        private int getNextID()
        {
            if(ExampleList2 != null && ExampleList2.Count > 0)
            {
                return ExampleList2.Select(x => x.ID).Max() + 1;
            }
            return 0;
        }

        private void toggleVisibility()
        {
            ExampleVisibility = !ExampleVisibility;
        }
        #endregion
    }
}
