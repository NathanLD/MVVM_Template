namespace MVVM_Template.Utils.Common
{
    // Fichier pour stocker les strings et nombres constants. Eviter à tout prix les nombres et strings "magiques" dans le code !!
    // 1) Permet de donner un nom compréhensible aux variables pour la relecture
    // 2) On est sûr que les strings testés sont les mêmes (en tapant à la main, on risque de faire des fautes de frappe, oublier des espaces, etc...)
    // 3) Si l'une de ces valeurs est à modifier, il ne faut la modifier qu'ici (et pas dans tout le code)
    class Constants
    {
        public const string EXAMPLE_STRING = "Obiwan Kenobi";
        public const int EXAMPLE_INT = 42;
    }
}
