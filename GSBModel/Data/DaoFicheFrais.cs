using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GSBModel.Business;

namespace GSBModel.Data
{
    public class DaoFicheFrais
    {
        private Dbal theDbal;

        public DaoFicheFrais(Dbal unDbal)
        {
            theDbal = unDbal;
        }

        public List<FicheFrais> SelectAll()
        {
            List<FicheFrais> listeFichesFrais = new List<FicheFrais>();
            DataTable myTable = theDbal.SelectAll("Etat");
            foreach (DataRow r in myTable.Rows)
            {
                listeFichesFrais.Add(new FicheFrais((int)r["id"], (string)r["mois"], (int)r["nbJustificatifs"], (decimal)r["montantValid"], (DateTime)r["dateModif"], (User)r["user"], (Etat)r["etat"]));
            }

            return listeFichesFrais;

        }
    }
}


  