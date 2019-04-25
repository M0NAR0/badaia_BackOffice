using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BADAIA_BackOffice.VM
{
    class VueModeleType_Logement
    {
        Modele.Donnees db = new Modele.Donnees();

        public void nouveauTypeLogement()
        {
            db.type_logement.Add(new Modele.type_logement()
            {
                LBL_TYPE = "nouveau"
            });
            db.SaveChanges();
            var l = db.type_logement.ToList();

            MessageBox.Show(l.LastOrDefault<Modele.type_logement>().LBL_TYPE);
        }

        public void afficherUnTypeLogement()
        {
            //Selectionner un type logement
            var produit = from tl in db.type_logement
                          where tl.ID_TYPE == 1
                          select tl;
            MessageBox.Show(produit.ToList()[0].LBL_TYPE);
        }

        public void afficherTousTypeLogement()
        {
            //Selectionner des types logement
            var produits = from tl in db.type_logement
                           select tl;
            string result = "";
            foreach (var p in produits.ToList())
            {
                result += p.LBL_TYPE + " ";
            }
            MessageBox.Show(result);
        }

        public void modifierUnTypeLogement()
        {
            //Modifier un type logement
            var modif_tl = from tl in db.type_logement
                            select tl;
            modif_tl.ToList().Last<Modele.type_logement>().LBL_TYPE = "nouveautés";
            db.SaveChanges();
        }

        public void supprimerUnTypeLogement()
        {
            //Supression d'un type logement
            var sup_tl = from tl in db.type_logement
                          where tl.ID_TYPE == 4
                          select tl; var l = db.type_logement.ToList();
            db.type_logement.Remove(sup_tl.ToList()[0]);
            db.SaveChanges();
        }
    }
}
