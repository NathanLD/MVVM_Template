using System;

namespace MVVM_Template.Utils.Common
{
    // Interface dont doivent hériter les ViewModel. Permet de donner à chaque vue un ID unique et donc de les identifier lors d'une itération sur les fenêtres actives.
    public interface IRequireViewIdentification
    {
        Guid ViewID { get; }
    }
}
