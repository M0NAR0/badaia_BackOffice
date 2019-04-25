namespace BADAIA_BackOffice.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2017-badaia_first.commentaire")]
    public partial class commentaire
    {
        [Key]
        public int ID_COMM { get; set; }

        public int ID_USER { get; set; }

        public int ID_ANN { get; set; }

        [Required]
        [StringLength(50)]
        public string TITRE { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string CONTENU { get; set; }

        public int NOTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_COMM { get; set; }

        public virtual annonce annonce { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
