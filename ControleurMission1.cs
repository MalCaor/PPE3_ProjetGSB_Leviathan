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

        private Visiteur leVisiteur;
        private static bool connexionValide;

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return (sb.ToString());
        }

        public static string validConnexion(string identifiant, string motDePasse)
        {
            string message = "";
            message = GetMd5Hash(motDePasse.ToString());
            return message;
        }
    }
}
