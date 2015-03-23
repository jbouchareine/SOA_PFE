namespace SOA_PFE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOA_User
    {
        public SOA_User()
        {
            SOA_Gestion_Messages = new HashSet<SOA_Gestion_Messages>();
            SOA_Gestion_Messages1 = new HashSet<SOA_Gestion_Messages>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public virtual ICollection<SOA_Gestion_Messages> SOA_Gestion_Messages { get; set; }

        public virtual ICollection<SOA_Gestion_Messages> SOA_Gestion_Messages1 { get; set; }
    }
}
