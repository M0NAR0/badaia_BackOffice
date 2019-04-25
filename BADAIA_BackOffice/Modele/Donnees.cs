namespace BADAIA_BackOffice.Modele
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Donnees : DbContext
    {
        public Donnees()
            : base("name=Donnees")
        {
        }

        public virtual DbSet<annonce> annonce { get; set; }
        public virtual DbSet<commentaire> commentaire { get; set; }
        public virtual DbSet<reservation> reservation { get; set; }
        public virtual DbSet<type_logement> type_logement { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<annonce>()
                .Property(e => e.TITRE)
                .IsUnicode(false);

            modelBuilder.Entity<annonce>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<annonce>()
                .Property(e => e.VILLE)
                .IsUnicode(false);

            modelBuilder.Entity<annonce>()
                .Property(e => e.ADRESSE)
                .IsUnicode(false);

            modelBuilder.Entity<annonce>()
                .Property(e => e.IMAGE)
                .IsUnicode(false);

            modelBuilder.Entity<commentaire>()
                .Property(e => e.TITRE)
                .IsUnicode(false);

            modelBuilder.Entity<commentaire>()
                .Property(e => e.CONTENU)
                .IsUnicode(false);

            modelBuilder.Entity<reservation>()
                .Property(e => e.STATUS_RES)
                .IsUnicode(false);

            modelBuilder.Entity<type_logement>()
                .Property(e => e.LBL_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.NOM)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.PRENOM)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.MDP)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<utilisateur>()
                .Property(e => e.PAYS)
                .IsUnicode(false);
        }
    }
}
