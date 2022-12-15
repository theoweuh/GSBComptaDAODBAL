using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBModel.Business
{
    public class FicheFrais
    {

        private int id;
        private string mois;
        private int nbJustificatifs;
        private decimal montantValid;
        private DateTime dateModif;
        private User user;
        private Etat etat;


        public FicheFrais(int id, string mois, int nbJustificatifs, decimal montantValid, DateTime dateModif, User user, Etat etat)
        {
            this.id = id;
            this.mois = mois;
            this.nbJustificatifs = nbJustificatifs;
            this.montantValid = montantValid;
            this.dateModif = dateModif;
        }

        public int Id { get => id; set => id = value; }
        public string Mois { get => mois; set => mois = value; }
        public int NbJustificatifs { get => nbJustificatifs; set => nbJustificatifs = value; }
        public decimal MontantValid { get => montantValid; set => montantValid = value; }
        public DateTime DateModif { get => dateModif; set => dateModif = value; }
        public User User { get => user; set => user = value; }
        public Etat Etat { get => etat; set => etat = value; }
    }
}
