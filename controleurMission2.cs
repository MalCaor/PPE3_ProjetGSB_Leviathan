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

        //Fonctions d'appel des liste depuis la BDD

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

        public static List<LigneFraisHorsForfait> listeLigneFraisHorsForfaits()
        {
            return maConnexion.LigneFraisHorsForfait.ToList();
        }

        public static List<MEDECIN> listeMedecins()
        {
            return maConnexion.MEDECIN.ToList();
        }
        
        public static List<MEDICAMENT> listeMedicaments()
        {
            return maConnexion.MEDICAMENT.ToList();
        }

        public static List<MOTIF> listeMOTIFS()
        {
            return maConnexion.MOTIF.ToList();
        }

        public static List<OFFRIR> listeOffrir()
        {
            return maConnexion.OFFRIR.ToList();
        }

        public static List<RAPPORT> listeRapports()
        {
            return maConnexion.RAPPORT.ToList();
        }

        public static List<Region> listeRegions()
        {
            return maConnexion.Region.ToList();
        }

        public static List<Secteur> listeSecteurs()
        {
            return maConnexion.Secteur.ToList();
        }

        public static List<SPECIALITE> listeSpecialités()
        {
            return maConnexion.SPECIALITE.ToList();
        }

        public static List<Visiteur> listeVisiteurs()
        {
            return maConnexion.Visiteur.ToList();
        }

        public static List<RAPPORT> listeRapportV(Visiteur V)
        {
            List<RAPPORT> RapportsV = new List<RAPPORT>();

            foreach(RAPPORT R in listeRapports())
            {
                if(V.identifiant == R.idVisiteur)
                {
                    RapportsV.Add(R);
                }
            }
            
            return RapportsV;
        }
        public static List<MEDECIN> listeMedecinsSuivi(Visiteur V)
        {
            List<MEDECIN> MedecinsV = new List<MEDECIN>();
            bool parcours;
            foreach(RAPPORT R in V.RAPPORT /*listeRapportV(V)*/)
            {
                parcours = false;
                foreach (MEDECIN M in MedecinsV)
                {
                    if (M.idMedecin == R.idMedecin)
                    {
                        parcours = true;
                    }
                    else
                    {
                        MedecinsV.Add(M);
                    }
                }
            }
            return MedecinsV;
        }

        /*public static Object VisiteurTest()
        {
            
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.id)
            
        }*/

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
