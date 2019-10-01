using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Leviathan
{
    class controleurMission2
    {
        // Set la connexion avec la base
        public static Leviathan_PPE3Entities maConnexion;
        
        public static void init()
        {
            //init de la connexion
            maConnexion = new Leviathan_PPE3Entities();
        }

        /*public static List<BATIMENT> listebatiment()
        {
            return maConnexion.BATIMENT.ToList();
        }*/

        public static List<Etat> listeEtats()
        {
            return maConnexion.Etat.ToList();
        }

        public static List<FAMILLE> listeFamilles()
        {
            return maConnexion.FAMILLE.ToList();
        }

        public static List<fichefrais> listeFichesFrais()
        {
            return maConnexion.fichefrais.ToList();
        }

        public static List<FraisForfait> listeFraisForfaits()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static List<Laboratoire> listeLaboratoires()
        {
            return maConnexion.Laboratoire.ToList();
        }

        public static List<LigneFraisForfait> listeLigneFraisForfaits()
        {
            return maConnexion.LigneFraisForfait.ToList();
        }
        /*public static Object CompositeurParNationalite(int idNation)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idNation == idNation)
                           .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }*/

        //Fonction touchant à la base de donnée
    }
}
