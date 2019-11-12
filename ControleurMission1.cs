using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_Leviathan
{
    class ControleurMission1
    {
        private static Leviathan_PPE3Entities maConnexion;

        public static void init()
        {
            maConnexion = new Leviathan_PPE3Entities(); 
        }
        public static void SaveChanges()
        {
            maConnexion.SaveChanges();
        }

        //----------------------CONNEXION-----------------------

        public static Visiteur leVisiteur;
        private static Laboratoire leLabo;
        private static bool connexionValide = false;
        private static string nomConnexion;


        private static string GetMd5Hash(string PasswdSaisi) //Cryptage du mot de passe
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return ("0x"+sb.ToString().ToUpper());
        }

        public static string validConnexion(string identifiantVisiteur, string motDePasse)
        {
            string message = "";
            try
            {            
                var LQuery = maConnexion.Visiteur.ToList()
                               .Where(x => x.identifiant == identifiantVisiteur);    
                leVisiteur = (Visiteur)LQuery.First();
                if (leVisiteur.password.ToString() == GetMd5Hash(motDePasse.ToString()) || leVisiteur.password.ToString() == motDePasse)
                {
                    connexionValide = true;
                    message = message + "Connecté";
                }
                else
                {
                    connexionValide = false;
                    message = message + "Erreur de mot de passe ou Identifiant incorrect";
                }
            }
            catch(Exception ex)
            {
                message = "Erreur de mot de passe ou Identifiant incorrect";
            }
            
            return message;
        }
        public static bool getConnexionValide()
        {
            return connexionValide;
        }
        public static List<Visiteur> listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }

        // conserve l'identifiant de la personne connectée
        public static void setIdentifiantConnexion(string identifiant) 
        {
            nomConnexion = identifiant;
        }

        //Verification si ADMIN
        private static bool boolADMIN = false;
        public static void verifConnexionAdmin()
        {
            if(getPrenomVisiteur()=="Admin" && getNomVisiteur()=="Admin" && nomConnexion=="Admin")
            {
                boolADMIN = true;
            }
        }
        public static bool getVerifAdmin()
        {
            return boolADMIN;
        }

        //Verification si le visiteur gère un secteur ou une region
        private static bool boolGestionSecteur = false;
        private static bool boolGestionRegion = false;
        public static bool verifGestionSecteur()
        {
            List<Secteur> lesSecteurs = leVisiteur.Secteur.ToList();
            foreach(Secteur s in lesSecteurs)
            {
                if (leVisiteur.idVisiteur == s.idVisiteur)
                {
                    boolGestionSecteur = true;
                }
            }
            return boolGestionSecteur;
        }
        public static bool verifGestionRegion()
        {
            List<Region> lesRegions = leVisiteur.Region.ToList();
            foreach(Region r in lesRegions)
            {
                if (leVisiteur.idVisiteur == r.idVisiteur)
                {
                    boolGestionRegion = true;
                }
            }
            return boolGestionRegion;
        }
        public static bool getGestionSecteur()
        {
            return boolGestionSecteur;
        }
        public static bool getGestionRegion()
        {
            return boolGestionRegion;
        }


        //-------------GETTER DE LA PERSONNE CONNECTEE-------------------------------


        public static string getIDVisiteur()
        {
            return InfoVisiteur(nomConnexion).idVisiteur;
        }
        public static string getNomVisiteur()
        {
            return InfoVisiteur(nomConnexion).nom;
        }
        public static string getPrenomVisiteur()
        {
            return InfoVisiteur(nomConnexion).prenom;
        }
        public static string getAdresseVisiteur()
        {
            return InfoVisiteur(nomConnexion).rue + " " + InfoVisiteur(nomConnexion).cp + " " + InfoVisiteur(nomConnexion).ville;
        }
        public static string getIDLaboVisiteur()
        {
            var labo = maConnexion.Laboratoire.ToList().Where(x => x.idLabo == InfoVisiteur(nomConnexion).idLabo);
            leLabo = (Laboratoire)labo.First();
            return leLabo.nomLabo;
        }
        public static List<Region> getRegionVisiteur()
        {
            return InfoVisiteur(nomConnexion).Region.ToList();
        }



        // Prend toutes les infos du visiteur passé en paramètre
        public static Visiteur InfoVisiteur(string identifiantVisiteur)
        {
            Visiteur vretour;
            var LQuery = maConnexion.Visiteur.ToList()
                               .Where(x => x.identifiant == identifiantVisiteur);
            vretour = (Visiteur)LQuery.First();
            return vretour;
        }
        public static Visiteur LesInfosVisiteur()
        {
            Visiteur vretour;
            var LQuery = maConnexion.Visiteur.ToList()
                               .Where(x => x.identifiant == nomConnexion);
            vretour = (Visiteur)LQuery.First();
            return vretour;
        }


        //CHOIX POUR LA VISUALISATION DES VISITEURS

        public static string choixVisuVisiteur;
        public static void setChoixVisualisationVisiteurs(string valeur)
        {
            choixVisuVisiteur = valeur;
        }
        public static string getChoixVisualisationVisiteurs()
        {
            return choixVisuVisiteur;
        }

        public static List<string> ListeChoixVisualisation()
        {
            List<string> vretour = new List<string>();
            vretour.Add("Global");
            vretour.Add("Par Secteur");
            vretour.Add("Par Région");

            return vretour;
        }

        public static Object listeVisiteursVisualisation(string valeur)
        {
            //Visiteur vretour;
            //if (valeur == "Par Région")
           // {
                var LQuery = maConnexion.Visiteur.ToList()
                            .Where(x => x.Region == listeRegionVisiteur(x.idVisiteur))
                            .OrderBy(x=>x.Region);
                return (Visiteur)LQuery;
           // }
           // return vretour;
        }
        public static Object listeRegionVisiteur(string idVisiteurPara)
        {
            var LQuery = maConnexion.Region.ToList()
                .Where(x => x.idVisiteur == idVisiteurPara);
            return (Region)LQuery;
        }





        //LISTE DES TABLES DE LA BASE DE DONNEES
        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<Region> listeRegion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Secteur> listeSecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        public static List<Laboratoire> listeLaboratoire()
        {
            return maConnexion.Laboratoire.ToList();
        }

    }
}
