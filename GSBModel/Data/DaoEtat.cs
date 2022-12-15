using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBModel.Business;

namespace GSBModel.Data
{
    public class DaoEtat
    {
        private Dbal theDbal;

        public DaoEtat(Dbal unDbal)
        {
            theDbal = unDbal;
        }

        public List<Etat> SelectAll()
        {
            List<Etat> listeEtats = new List<Etat>();
            DataTable myTable = theDbal.SelectAll("Etat");
            foreach (DataRow r in myTable.Rows)
            {
                listeEtats.Add(new Etat((int)r["id"], (string)r["libelle"]));
            }


            return listeEtats;
        }
        public Etat SelectById(int id)
        {
            DataRow myTable = theDbal.SelectById("etat", id);
            DataRow result = this.theDbal.SelectById("Etat", id);
            return new Etat((int)result["id"], (string)result["libelle"]);

        }
    }
}
