using System;
using GSBModel.Business;
using GSBModel.Data;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ici le code pour tester les classes DBAL/DAO etc...
            Dbal unDbal = new Dbal("gsb_frais_symfony");
            DaoEtat unDaoEtat = new DaoEtat(unDbal);

            List<Etat> lesEtats = unDaoEtat.SelectAll();

            foreach (Etat unEtat in lesEtats)
            {
                Console.WriteLine(unEtat.Id + "-" + unEtat.Libelle);
            }

        }
        static void Main2(string[] args)
        {
            Dbal dbalFicheFrais = new Dbal("gsb_frais_synfony");
            DaoFicheFrais daoFicheFrais = new DaoFicheFrais(dbalFicheFrais);

            List<FicheFrais> lesFichesFrais = daoFicheFrais.SelectAll();

            foreach (FicheFrais uneFicheFrais in lesFichesFrais)

            {
                Console.WriteLine(uneFicheFrais.Id);

            }
        }
    }
}