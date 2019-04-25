namespace BADAIA_BackOffice.Modele
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2017-badaia_first.type_logement")]
    public partial class type_logement
    {
        [Key]
        public int ID_TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string LBL_TYPE { get; set; }
    }
}
