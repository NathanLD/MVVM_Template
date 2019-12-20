using MVVM_Template.Utils.MVVM;
using System;
using System.Windows;

namespace MVVM_Template.Utils.Common
{
    // Classe utilitaire pour gérer une application avec plusieurs fenêtres actives.
    public static class WindowManager
    {
        // Ferme l'instance de la fenêtre identifiée par le GUID donné
        public static void CloseWindow(Guid id)
        {
            foreach (Window window in Application.Current.Windows)
            {
                var w_id = window.DataContext as IRequireViewIdentification;
                if (w_id != null && w_id.ViewID.Equals(id))
                {
                    window.Close();
                }
            }
        }

        // Renvoie TRUE si aucune instance de la Vue (ou VueModel) n'est trouvée.
        public static bool DoesNotExist(Type typeToOpen)
        {
            foreach (Window window in Application.Current.Windows)
            {
                var windowViewModel = window.DataContext as ViewModelBase;
                if (windowViewModel != null)
                {
                    Type windowType = windowViewModel.GetType();
                    if (windowType == typeToOpen)
                    {
                        window.Activate();  // Si la fenêtre existe déjà, ramène la fenêtre au premier plan
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
