using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Template.Model.POCO
{
    // Exemple d'objet POCO (Plain Old C# Object) : un objet simple, contenant juste des données
    class ExampleObject
    {
        public ExampleObject(int id, string text)
        {
            this.ID = id;
            this.text = text;
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
