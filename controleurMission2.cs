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

        public static void SaveChanges()
        {
            maConnexion.SaveChanges();
        }

        public static Visiteur leVisiteur;

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

        //------------------CONNEXION------------------
        //-------------------SIMULER-------------------

        public static Visiteur logInfoVisiteur()
        {


            foreach (Visiteur V in listeVisiteurs())
            {
                if (V.idVisiteur == "a13")
                {
                    leVisiteur = V;
                }
            }

            return leVisiteur;
        }

        // TRAITEMENT INFO VISITEUR

        // Récupération de la liste des rapport du visiteur
        public static List<RAPPORT> listeRapportV(Visiteur V)
        {
            List<RAPPORT> RapportsV = new List<RAPPORT>();

            foreach(RAPPORT R in listeRapports())
            { 
                if(V.idVisiteur == R.idVisiteur)
                {
                    RapportsV.Add(R);
                }
            }
            
            return RapportsV;
        }

        //Récupération de la liste des médecins suivi par le visiteur connecté
        public static List<MEDECIN> listeMedecinsSuivi(Visiteur V)
        {
            List<MEDECIN> MedecinsV = new List<MEDECIN>();
            List<MEDECIN> Medecins = new List<MEDECIN>();
            List<RAPPORT> RapportV = new List<RAPPORT>();
            
            foreach(RAPPORT R in /*V.RAPPORT*/ listeRapportV(V))
            {
                //Vérification de l'existance du médecins du rapport dans la liste MedecinsV
                if (verifSuivi(MedecinsV, R) == false)
                {
                    //Ajout du médecins du rapport à la liste 
                    MedecinsV.Add(R.MEDECIN);
                }
            }
            return MedecinsV;
        }

        //Vérification de l'existance du médecin dans la liste en cour dans la fonction listeMedecinsSuivi(Visiteur V)
        public static bool verifSuivi(List<MEDECIN> MedecinsV, RAPPORT R)
        {
            bool vretour = false;

            foreach(MEDECIN M in MedecinsV)
            {
                if (M.idMedecin == R.idMedecin)
                {
                    vretour = true;
                }
            }

            return vretour;
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
