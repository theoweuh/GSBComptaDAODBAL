using GSBModel.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBModel.Business
{
    public class User
    {
        public User(int id, string login, Array role, string nom, string prenom, string adresse, string cp, string ville, date dateEmbauche)
        {
            Id = id;
            this.login = login;
            this.role = role;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.dateEmbauche = dateEmbauche;
        }

        private int Id { get; set; }
        private string login { get; set; }
        private Array role { get; set; }
        private string nom { get; set; }
        private string prenom { get; set; }
        private string adresse { get; set; }
        private string cp { get; set; }
        private string ville { get; set; }
        private date dateEmbauche { get; set; }

    
    }





}
