using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBModel.Business
{
    public class FraisForfait
    {
        public FraisForfait(int id, string libelle, decimal montant)
        {
            this.id = id;
            this.libelle = libelle;
            this.montant = montant;
        }

        private int id { get; set; }
        private string libelle { get; set; }
        private decimal montant { get; set; }

    }
}
