﻿using System;
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

        // conserve l'identifiant de la personne connectée
        public static void setIdentifiantConnexion(string identifiant) 
        {
            nomConnexion = identifiant;
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
        public static void VisualisationVisiteurs(string valeur)
        {
            choixVisuVisiteur = valeur;
            List<string> leschoix = new List<string>();
            leschoix.Add("global");
            leschoix.Add("par secteur");
            leschoix.Add("par regions");
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
            var LQuery = maConnexion.
            return (Visiteur)LQuery;
        }


    }
}
