using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBModel.Business
{
    public class Etat
    {
        private int id;
        private string libelle;

        public int Id { get; set; }
        public string Libelle { get; set; }

        public Etat(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }



    }
}
