namespace MVVM_Template.Utils.Repository
{
    class ExampleRepository
    {
        internal string FindUserName(int id)
        {
            string name = "USER NOT FOUND";

            // Exemple avec EntityFramework :
            /*
            using (BDDEntities bdd = new BDDEntities())
            {
                var result = bdd.USERS.FirstOrDefault(x => x.ID == id);
                if (result != null)
                {
                    name = result.NAME;
                }
            }
            */

            return name;
        }

        internal void UpdateUserNameByID(int id, string name)
        {
            // Exemple avec EntityFramework :
            /*
            using (BDDEntities bdd = new BDDEntities())
            {
                var result = bdd.USERS.FirstOrDefault(x => x.ID == id);
                if (result != null)
                {
                    result.NAME = name;
                    bdd.SaveChanges();
                }
            }
            */
        }
    }
}
