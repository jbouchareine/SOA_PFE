namespace SOA_PFE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOA_Gestion_Messages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int idSender { get; set; }

        public int idRecipient { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? sentDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? receiptDate { get; set; }

        public virtual SOA_User SOA_User { get; set; }

        public virtual SOA_User SOA_User1 { get; set; }
    }
}
