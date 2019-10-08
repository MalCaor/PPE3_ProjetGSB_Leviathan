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
            var LQuery = maConnexion.Visiteur.ToList()
                               .Where(x => x.identifiant == identifiantVisiteur);    
            leVisiteur = (Visiteur)LQuery.First();
            if(leVisiteur.password.ToString() == GetMd5Hash(motDePasse.ToString()))
            {
                connexionValide = true;
                message = message + "Connecté";
            }
            else
            {
                connexionValide = false;
                message = message + "Erreur de mot de passe ou Identifiant incorrect";
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
        public static void setIdentifiantConnexion(string identifiant) // conserve l'identifiant de la personne connectée
        {
            nomConnexion = identifiant;
        }


        //-------------GETTER DE LA PERSONNE CONNECTEE


        public static string getIDVisiteur(string identifiantVisiteur)
        {
            return InfoVisiteur(identifiantVisiteur).idVisiteur;
        }
        public static string getNomVisiteur(string identifiantVisiteur)
        {
            return InfoVisiteur(identifiantVisiteur).nom;
        }
        public static string getPrenomVisiteur(string identifiantVisiteur)
        {
            return InfoVisiteur(identifiantVisiteur).prenom;
        }
        public static string getAdresseVisiteur(string identifiantVisiteur)
        {
            return InfoVisiteur(identifiantVisiteur).rue + " " + InfoVisiteur(identifiantVisiteur).cp + " " + InfoVisiteur(identifiantVisiteur).ville;
        }
        public static string getIDLaboVisiteur(string identifiantVisiteur)
        {
            var labo = maConnexion.Laboratoire.ToList().Where(x => x.idLabo == InfoVisiteur(identifiantVisiteur).idLabo);
            leLabo = (Laboratoire)labo.First();
            return leLabo.nomLabo;
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
    }
}
