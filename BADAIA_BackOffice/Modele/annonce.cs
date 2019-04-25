namespace BADAIA_BackOffice.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2017-badaia_first.annonce")]
    public partial class annonce
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public annonce()
        {
            commentaire = new HashSet<commentaire>();
            reservation = new HashSet<reservation>();
        }

        [Key]
        public int ID_ANN { get; set; }

        public int ID_TYPE { get; set; }

        public int ID_USER { get; set; }

        [Required]
        [StringLength(150)]
        public string TITRE { get; set; }

        public decimal PRIX { get; set; }

        public int NBPLACE { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(50)]
        public string VILLE { get; set; }

        [Required]
        [StringLength(100)]
        public string ADRESSE { get; set; }

        [StringLength(150)]
        public string IMAGE { get; set; }

        public virtual utilisateur utilisateur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentaire> commentaire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservation { get; set; }
    }
}
