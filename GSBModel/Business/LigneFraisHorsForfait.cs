using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBModel.Business
{
    public class LigneFraisHorsForfait
    {
        public LigneFraisHorsForfait(int id, string libelle, date date, decimal montant)
        {
            this.id = id;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant;
        }

        private int id { get; set; }
        private string libelle { get; set; }
        private date date { get; set; }
        private decimal montant { get; set; }
        
    }
    
    public class date
    {

    }
}
