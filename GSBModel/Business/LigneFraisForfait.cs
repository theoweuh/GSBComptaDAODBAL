using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBModel.Business
{
    public class LigneFraisForfait
    {
        public LigneFraisForfait(int id, int quantite)
        {
            this.id = id;
            this.quantite = quantite;
        }

        private int id { get; set; }
        private int quantite { get; set; }

    }
}
