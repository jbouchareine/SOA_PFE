namespace SOA_PFE
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=modèle_SOA")
        {
        }

        public virtual DbSet<SOA_Gestion_Messages> SOA_Gestion_Messages { get; set; }
        public virtual DbSet<SOA_Messages> SOA_Messages { get; set; }
        public virtual DbSet<SOA_User> SOA_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SOA_Messages>()
                .Property(e => e.msg)
                .IsUnicode(false);

            modelBuilder.Entity<SOA_User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<SOA_User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<SOA_User>()
                .HasMany(e => e.SOA_Gestion_Messages)
                .WithRequired(e => e.SOA_User)
                .HasForeignKey(e => e.idRecipient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOA_User>()
                .HasMany(e => e.SOA_Gestion_Messages1)
                .WithRequired(e => e.SOA_User1)
                .HasForeignKey(e => e.idSender)
                .WillCascadeOnDelete(false);
        }
    }
}
