namespace BADAIA_BackOffice.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2017-badaia_first.reservation")]
    public partial class reservation
    {
        [Key]
        public int ID_RES { get; set; }

        public int ID_ANN { get; set; }

        public int ID_USER { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_DEB_RES { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_FIN_RES { get; set; }

        public int NBPERS_RES { get; set; }

        [Required]
        [StringLength(50)]
        public string STATUS_RES { get; set; }

        public virtual annonce annonce { get; set; }

        public virtual utilisateur utilisateur { get; set; }
    }
}
