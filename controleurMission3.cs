﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Leviathan
{
    public static class controleurMission3
    {
        // Set la Connexion avec la base
        private static Leviathan_PPE3Entities maConnexion;
        
        public static void init()
        {
            // init Connexion
            maConnexion = new Leviathan_PPE3Entities();
        }

        public static List<fichefrais> listeFicheFrais()
        {
            return maConnexion.fichefrais.ToList();
        }

        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }


        public static List<string> nomVisit()
        {
            List<string> listprenom = new List<string>();
            List<Visiteur> listVisit = listeVisiteur();
            foreach (Visiteur visiteur in listVisit)
            {
                listprenom.Add(visiteur.prenom + visiteur.nom);
            }
            return listprenom;
        }

        public static Visiteur visiteurIDSearch(string nompre)
        {
            List<Visiteur> listVisit = listeVisiteur();
            foreach (Visiteur visiteur in listVisit)
            {
                if (nompre == visiteur.prenom + visiteur.nom)
                {
                    return visiteur;
                }
            }
            return null;
        }

        public static List<fichefrais> listFicheFraisVisiteur(Visiteur v)
        {
            List<fichefrais> ficheFFRetour = new List<fichefrais>();
            List<fichefrais> listeFicheFrais = controleurMission3.listeFicheFrais();
            foreach(fichefrais ff in listeFicheFrais)
            {
                if (v.idVisiteur == ff.idVisiteur)
                {
                    ficheFFRetour.Add(ff);
                }
            }
            return ficheFFRetour;
        }
    }
}
