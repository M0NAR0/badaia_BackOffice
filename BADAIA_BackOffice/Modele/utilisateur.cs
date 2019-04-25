namespace BADAIA_BackOffice.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2017-badaia_first.utilisateur")]
    public partial class utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilisateur()
        {
            annonce = new HashSet<annonce>();
            commentaire = new HashSet<commentaire>();
            reservation = new HashSet<reservation>();
        }

        [Key]
        public int ID_USER { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM { get; set; }

        [Required]
        [StringLength(50)]
        public string PRENOM { get; set; }

        [Required]
        [StringLength(50)]
        public string MDP { get; set; }

        [Required]
        [StringLength(100)]
        public string MAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string TEL { get; set; }

        [Required]
        [StringLength(50)]
        public string PAYS { get; set; }

        public bool EST_HOTE { get; set; }

        public bool EST_ADMIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<annonce> annonce { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire> commentaire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservation { get; set; }
    }
}
