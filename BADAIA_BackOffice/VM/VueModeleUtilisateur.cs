using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Cryptography;

namespace BADAIA_BackOffice.VM
{
    class VueModeleUtilisateur
    {
        Modele.Donnees db = new Modele.Donnees();

        /**
         * Hash en Sha1
         */
        public string toSHA1(string text)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach(byte b in re)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        public void nouveauUtilisateur()
        {
            db.utilisateur.Add(new Modele.utilisateur()
            {
                NOM = "nouveau",
                PRENOM = "nouveau",
                MAIL = "nouveau",
                TEL = "nouveau",
                PAYS = "NOUVEAU",
                MDP = toSHA1("nouveau"),
                EST_HOTE = false,
                EST_ADMIN = false
            });
            db.SaveChanges();
            var l = db.utilisateur.ToList();

            MessageBox.Show(l.LastOrDefault<Modele.utilisateur>().MDP);
        }

        public void afficherUnUtilisateur()
        {
            //Selectionner un utilisateur
            var produit = from t in db.utilisateur
                          where t.MAIL == "nouveau"
                          select t;
            MessageBox.Show(produit.ToList()[0].MAIL);
        }

        public void afficherTousUtilisateurs()
        {
            //Selectionner des utilisateurs
            var produits = from t in db.utilisateur
                           select t;
            string result = "";
            foreach (var p in produits.ToList())
            {
                result += p.MAIL + " \n";
            }
            MessageBox.Show(result);
        }

        public void modifierUnUtilisateur()
        {
            //Modifier un type logement
            var modif_t = from t in db.utilisateur
                          select t;
            modif_t.ToList().Last<Modele.utilisateur>().MAIL = "nouveauModif";
            db.SaveChanges();
        }

        public void supprimerUnUtilisateur()
        {
            //Supression d'un type logement
            var sup_t = from t in db.utilisateur
                        where t.MAIL == "nouveauModif"
                        select t;
            var l = db.utilisateur.ToList();
            db.utilisateur.Remove(sup_t.ToList()[0]);
            db.SaveChanges();
        }

        public Boolean tryToLogIn(string inputMail, string inputPassword)
        {
            var sha1MDP = toSHA1(inputPassword);
            try
            {
                //Selectionner un utilisateur
                var produit = from t in db.utilisateur
                              where t.MAIL == inputMail && t.MDP == sha1MDP
                              select t;
                return produit.ToList()[0].EST_ADMIN;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
                return false;
                throw;
            }
        }
    }
}
