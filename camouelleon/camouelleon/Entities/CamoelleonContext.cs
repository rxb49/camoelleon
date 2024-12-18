using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace camouelleon.Entities;

public partial class CamoelleonContext : DbContext
{
    public CamoelleonContext()
    {
    }

    public CamoelleonContext(DbContextOptions<CamoelleonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Allergie> Allergies { get; set; }

    public virtual DbSet<Attribuer> Attribuers { get; set; }

    public virtual DbSet<Avi> Avis { get; set; }

    public virtual DbSet<Cache> Caches { get; set; }

    public virtual DbSet<CacheLock> CacheLocks { get; set; }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<Dechet> Dechets { get; set; }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<Facture> Factures { get; set; }

    public virtual DbSet<FailedJob> FailedJobs { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobBatch> JobBatches { get; set; }

    public virtual DbSet<Lier> Liers { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<Produit> Produits { get; set; }

    public virtual DbSet<Ranger> Rangers { get; set; }

    public virtual DbSet<Reaprovisionnement> Reaprovisionnements { get; set; }

    public virtual DbSet<Reaprovisionner> Reaprovisionners { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Unite> Unites { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.158.44;port=3306;user=dev1;password=P@ssw0rd;database=camoelleon", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Allergie>(entity =>
        {
            entity.HasKey(e => e.Idallergie).HasName("PRIMARY");

            entity.ToTable("allergie");

            entity.Property(e => e.Idallergie).HasColumnName("IDALLERGIE");
            entity.Property(e => e.Lblallergie)
                .HasMaxLength(50)
                .HasColumnName("LBLALLERGIE");
        });

        modelBuilder.Entity<Attribuer>(entity =>
        {
            entity.HasKey(e => new { e.Idcommande, e.Idproduit })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("attribuer");

            entity.HasIndex(e => e.Idcommande, "I_FK_ATTRIBUER_COMMANDE");

            entity.HasIndex(e => e.Idproduit, "I_FK_ATTRIBUER_PRODUIT");

            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Idproduit).HasColumnName("IDPRODUIT");
            entity.Property(e => e.Quantite).HasColumnName("QUANTITE");

            entity.HasOne(d => d.IdcommandeNavigation).WithMany(p => p.Attribuers)
                .HasForeignKey(d => d.Idcommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ATTRIBUER_ibfk_1");

            entity.HasOne(d => d.IdproduitNavigation).WithMany(p => p.Attribuers)
                .HasForeignKey(d => d.Idproduit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ATTRIBUER_ibfk_2");
        });

        modelBuilder.Entity<Avi>(entity =>
        {
            entity.HasKey(e => e.Idavis).HasName("PRIMARY");

            entity.ToTable("avis");

            entity.Property(e => e.Idavis).HasColumnName("IDAVIS");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(250)
                .HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Datecreation).HasColumnName("DATECREATION");

            entity.HasMany(d => d.Idutilisateurs).WithMany(p => p.Idavis)
                .UsingEntity<Dictionary<string, object>>(
                    "Donner",
                    r => r.HasOne<Utilisateur>().WithMany()
                        .HasForeignKey("Idutilisateur")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("DONNER_ibfk_2"),
                    l => l.HasOne<Avi>().WithMany()
                        .HasForeignKey("Idavis")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("DONNER_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idavis", "Idutilisateur")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("donner");
                        j.HasIndex(new[] { "Idavis" }, "I_FK_DONNER_AVIS");
                        j.HasIndex(new[] { "Idutilisateur" }, "I_FK_DONNER_UTILISATEUR");
                        j.IndexerProperty<int>("Idavis").HasColumnName("IDAVIS");
                        j.IndexerProperty<int>("Idutilisateur").HasColumnName("IDUTILISATEUR");
                    });
        });

        modelBuilder.Entity<Cache>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity
                .ToTable("cache")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.Value)
                .HasColumnType("mediumtext")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CacheLock>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity
                .ToTable("cache_locks")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("owner");
        });

        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => e.Idcommande).HasName("PRIMARY");

            entity.ToTable("commande");

            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Nbclient).HasColumnName("NBCLIENT");

            entity.HasMany(d => d.Idtables).WithMany(p => p.Idcommandes)
                .UsingEntity<Dictionary<string, object>>(
                    "Commander",
                    r => r.HasOne<Table>().WithMany()
                        .HasForeignKey("Idtable")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("COMMANDER_ibfk_2"),
                    l => l.HasOne<Commande>().WithMany()
                        .HasForeignKey("Idcommande")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("COMMANDER_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idcommande", "Idtable")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("commander");
                        j.HasIndex(new[] { "Idcommande" }, "I_FK_COMMANDER_COMMANDE");
                        j.HasIndex(new[] { "Idtable" }, "I_FK_COMMANDER_TABLES");
                        j.IndexerProperty<int>("Idcommande").HasColumnName("IDCOMMANDE");
                        j.IndexerProperty<int>("Idtable").HasColumnName("IDTABLE");
                    });
        });

        modelBuilder.Entity<Dechet>(entity =>
        {
            entity.HasKey(e => e.Iddechet).HasName("PRIMARY");

            entity.ToTable("dechet");

            entity.Property(e => e.Iddechet).HasColumnName("IDDECHET");
            entity.Property(e => e.Datejeter).HasColumnName("DATEJETER");
            entity.Property(e => e.Quantite).HasColumnName("QUANTITE");

            entity.HasMany(d => d.Idproduits).WithMany(p => p.Iddechets)
                .UsingEntity<Dictionary<string, object>>(
                    "Jeter",
                    r => r.HasOne<Produit>().WithMany()
                        .HasForeignKey("Idproduit")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("JETER_ibfk_2"),
                    l => l.HasOne<Dechet>().WithMany()
                        .HasForeignKey("Iddechet")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("JETER_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Iddechet", "Idproduit")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("jeter");
                        j.HasIndex(new[] { "Iddechet" }, "I_FK_JETER_DECHET");
                        j.HasIndex(new[] { "Idproduit" }, "I_FK_JETER_PRODUIT");
                        j.IndexerProperty<int>("Iddechet").HasColumnName("IDDECHET");
                        j.IndexerProperty<int>("Idproduit").HasColumnName("IDPRODUIT");
                    });
        });

        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.Idetat).HasName("PRIMARY");

            entity.ToTable("etat");

            entity.Property(e => e.Idetat).HasColumnName("IDETAT");
            entity.Property(e => e.Lbletat)
                .HasMaxLength(50)
                .HasColumnName("LBLETAT");
        });

        modelBuilder.Entity<Facture>(entity =>
        {
            entity.HasKey(e => e.Idfacture).HasName("PRIMARY");

            entity.ToTable("facture");

            entity.HasIndex(e => e.Idcommande, "I_FK_FACTURE_COMMANDE");

            entity.Property(e => e.Idfacture).HasColumnName("IDFACTURE");
            entity.Property(e => e.Acompte).HasColumnName("ACOMPTE");
            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Montant).HasColumnName("MONTANT");
            entity.Property(e => e.Montantpaye).HasColumnName("MONTANTPAYE");
            entity.Property(e => e.Tva).HasColumnName("TVA");

            entity.HasOne(d => d.IdcommandeNavigation).WithMany(p => p.Factures)
                .HasForeignKey(d => d.Idcommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FACTURE_ibfk_1");
        });

        modelBuilder.Entity<FailedJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("failed_jobs")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Connection)
                .HasColumnType("text")
                .HasColumnName("connection");
            entity.Property(e => e.Exception).HasColumnName("exception");
            entity.Property(e => e.FailedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("failed_at");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.Queue)
                .HasColumnType("text")
                .HasColumnName("queue");
            entity.Property(e => e.Uuid).HasColumnName("uuid");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("jobs")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Queue, "jobs_queue_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.AvailableAt).HasColumnName("available_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.Queue).HasColumnName("queue");
            entity.Property(e => e.ReservedAt).HasColumnName("reserved_at");
        });

        modelBuilder.Entity<JobBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("job_batches")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CancelledAt).HasColumnName("cancelled_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FailedJobIds).HasColumnName("failed_job_ids");
            entity.Property(e => e.FailedJobs).HasColumnName("failed_jobs");
            entity.Property(e => e.FinishedAt).HasColumnName("finished_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Options)
                .HasColumnType("mediumtext")
                .HasColumnName("options");
            entity.Property(e => e.PendingJobs).HasColumnName("pending_jobs");
            entity.Property(e => e.TotalJobs).HasColumnName("total_jobs");
        });

        modelBuilder.Entity<Lier>(entity =>
        {
            entity.HasKey(e => new { e.Idetat, e.Idcommande })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("lier");

            entity.HasIndex(e => e.Idcommande, "I_FK_LIER_COMMANDE");

            entity.HasIndex(e => e.Idetat, "I_FK_LIER_ETAT");

            entity.Property(e => e.Idetat).HasColumnName("IDETAT");
            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Dateheure)
                .HasColumnType("datetime")
                .HasColumnName("DATEHEURE");

            entity.HasOne(d => d.IdcommandeNavigation).WithMany(p => p.Liers)
                .HasForeignKey(d => d.Idcommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LIER_ibfk_2");

            entity.HasOne(d => d.IdetatNavigation).WithMany(p => p.Liers)
                .HasForeignKey(d => d.Idetat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LIER_ibfk_1");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("migrations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<PasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PRIMARY");

            entity
                .ToTable("password_reset_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
        });

        modelBuilder.Entity<Produit>(entity =>
        {
            entity.HasKey(e => e.Idproduit).HasName("PRIMARY");

            entity.ToTable("produit");

            entity.HasIndex(e => new { e.Idunite, e.Lblunite }, "I_FK_PRODUIT_UNITE");

            entity.Property(e => e.Idproduit).HasColumnName("IDPRODUIT");
            entity.Property(e => e.Idunite).HasColumnName("IDUNITE");
            entity.Property(e => e.Lblproduit)
                .HasMaxLength(128)
                .HasColumnName("LBLPRODUIT");
            entity.Property(e => e.Lblunite)
                .HasMaxLength(30)
                .HasColumnName("LBLUNITE");
            entity.Property(e => e.Menudujour).HasColumnName("MENUDUJOUR");

            entity.HasOne(d => d.Unite).WithMany(p => p.Produits)
                .HasForeignKey(d => new { d.Idunite, d.Lblunite })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PRODUIT_ibfk_1");

            entity.HasMany(d => d.Idallergies).WithMany(p => p.Idproduits)
                .UsingEntity<Dictionary<string, object>>(
                    "Susceptible",
                    r => r.HasOne<Allergie>().WithMany()
                        .HasForeignKey("Idallergie")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("SUSCEPTIBLE_ibfk_2"),
                    l => l.HasOne<Produit>().WithMany()
                        .HasForeignKey("Idproduit")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("SUSCEPTIBLE_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idproduit", "Idallergie")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("susceptible");
                        j.HasIndex(new[] { "Idallergie" }, "I_FK_SUSCEPTIBLE_ALLERGIE");
                        j.HasIndex(new[] { "Idproduit" }, "I_FK_SUSCEPTIBLE_PRODUIT");
                        j.IndexerProperty<int>("Idproduit").HasColumnName("IDPRODUIT");
                        j.IndexerProperty<int>("Idallergie").HasColumnName("IDALLERGIE");
                    });
        });

        modelBuilder.Entity<Ranger>(entity =>
        {
            entity.HasKey(e => new { e.Idstock, e.Idproduit })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("ranger");

            entity.HasIndex(e => e.Idproduit, "I_FK_RANGER_PRODUIT");

            entity.HasIndex(e => e.Idstock, "I_FK_RANGER_STOCK");

            entity.Property(e => e.Idstock).HasColumnName("IDSTOCK");
            entity.Property(e => e.Idproduit).HasColumnName("IDPRODUIT");
            entity.Property(e => e.Quantite).HasColumnName("QUANTITE");

            entity.HasOne(d => d.IdproduitNavigation).WithMany(p => p.Rangers)
                .HasForeignKey(d => d.Idproduit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RANGER_ibfk_2");

            entity.HasOne(d => d.IdstockNavigation).WithMany(p => p.Rangers)
                .HasForeignKey(d => d.Idstock)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RANGER_ibfk_1");
        });

        modelBuilder.Entity<Reaprovisionnement>(entity =>
        {
            entity.HasKey(e => e.Idreaprovisionnement).HasName("PRIMARY");

            entity.ToTable("reaprovisionnement");

            entity.Property(e => e.Idreaprovisionnement).HasColumnName("IDREAPROVISIONNEMENT");
            entity.Property(e => e.Datereaprovisionnement).HasColumnName("DATEREAPROVISIONNEMENT");
        });

        modelBuilder.Entity<Reaprovisionner>(entity =>
        {
            entity.HasKey(e => new { e.Idreaprovisionnement, e.Idproduit })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("reaprovisionner");

            entity.HasIndex(e => e.Idproduit, "I_FK_REAPROVISIONNER_PRODUIT");

            entity.HasIndex(e => e.Idreaprovisionnement, "I_FK_REAPROVISIONNER_REAPROVISIONNEMENT");

            entity.Property(e => e.Idreaprovisionnement).HasColumnName("IDREAPROVISIONNEMENT");
            entity.Property(e => e.Idproduit).HasColumnName("IDPRODUIT");
            entity.Property(e => e.Quantite).HasColumnName("QUANTITE");

            entity.HasOne(d => d.IdproduitNavigation).WithMany(p => p.Reaprovisionners)
                .HasForeignKey(d => d.Idproduit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REAPROVISIONNER_ibfk_2");

            entity.HasOne(d => d.IdreaprovisionnementNavigation).WithMany(p => p.Reaprovisionners)
                .HasForeignKey(d => d.Idreaprovisionnement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("REAPROVISIONNER_ibfk_1");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Idreservation).HasName("PRIMARY");

            entity.ToTable("reservation");

            entity.HasIndex(e => e.Idutilisateur, "I_FK_RESERVATION_UTILISATEUR");

            entity.Property(e => e.Idreservation).HasColumnName("IDRESERVATION");
            entity.Property(e => e.Annulation).HasColumnName("ANNULATION");
            entity.Property(e => e.Confirmee).HasColumnName("CONFIRMEE");
            entity.Property(e => e.Datedebutreservation)
                .HasColumnType("datetime")
                .HasColumnName("DATEDEBUTRESERVATION");
            entity.Property(e => e.Datefinreservation)
                .HasColumnType("datetime")
                .HasColumnName("DATEFINRESERVATION");
            entity.Property(e => e.Idutilisateur).HasColumnName("IDUTILISATEUR");
            entity.Property(e => e.Nbpersonne).HasColumnName("NBPERSONNE");

            entity.HasOne(d => d.IdutilisateurNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Idutilisateur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RESERVATION_ibfk_1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Idrole).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.Idrole).HasColumnName("IDROLE");
            entity.Property(e => e.Lblrole)
                .HasMaxLength(128)
                .HasColumnName("LBLROLE");

            entity.HasMany(d => d.Idutilisateurs).WithMany(p => p.Idroles)
                .UsingEntity<Dictionary<string, object>>(
                    "Etre",
                    r => r.HasOne<Utilisateur>().WithMany()
                        .HasForeignKey("Idutilisateur")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("ETRE_ibfk_2"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("Idrole")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("ETRE_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idrole", "Idutilisateur")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("etre");
                        j.HasIndex(new[] { "Idrole" }, "I_FK_ETRE_ROLE");
                        j.HasIndex(new[] { "Idutilisateur" }, "I_FK_ETRE_UTILISATEUR");
                        j.IndexerProperty<int>("Idrole").HasColumnName("IDROLE");
                        j.IndexerProperty<int>("Idutilisateur").HasColumnName("IDUTILISATEUR");
                    });
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sessions")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.LastActivity, "sessions_last_activity_index");

            entity.HasIndex(e => e.UserId, "sessions_user_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasColumnName("ip_address");
            entity.Property(e => e.LastActivity).HasColumnName("last_activity");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.UserAgent)
                .HasColumnType("text")
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.Idstock).HasName("PRIMARY");

            entity.ToTable("stock");

            entity.Property(e => e.Idstock).HasColumnName("IDSTOCK");
            entity.Property(e => e.Lblstock)
                .HasMaxLength(30)
                .HasColumnName("LBLSTOCK");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Idtable).HasName("PRIMARY");

            entity.ToTable("tables");

            entity.HasIndex(e => e.Idzone, "I_FK_TABLES_ZONE");

            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");
            entity.Property(e => e.Estlibre).HasColumnName("ESTLIBRE");
            entity.Property(e => e.Idzone).HasColumnName("IDZONE");
            entity.Property(e => e.Nbplace).HasColumnName("NBPLACE");

            entity.HasOne(d => d.IdzoneNavigation).WithMany(p => p.Tables)
                .HasForeignKey(d => d.Idzone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TABLES_ibfk_1");

            entity.HasMany(d => d.Idreservations).WithMany(p => p.Idtables)
                .UsingEntity<Dictionary<string, object>>(
                    "Preserver",
                    r => r.HasOne<Reservation>().WithMany()
                        .HasForeignKey("Idreservation")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("PRESERVER_ibfk_2"),
                    l => l.HasOne<Table>().WithMany()
                        .HasForeignKey("Idtable")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("PRESERVER_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idtable", "Idreservation")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("preserver");
                        j.HasIndex(new[] { "Idreservation" }, "I_FK_PRESERVER_RESERVATION");
                        j.HasIndex(new[] { "Idtable" }, "I_FK_PRESERVER_TABLES");
                        j.IndexerProperty<int>("Idtable").HasColumnName("IDTABLE");
                        j.IndexerProperty<int>("Idreservation").HasColumnName("IDRESERVATION");
                    });
        });

        modelBuilder.Entity<Unite>(entity =>
        {
            entity.HasKey(e => new { e.Idunite, e.Lblunite })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("unite");

            entity.Property(e => e.Idunite)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDUNITE");
            entity.Property(e => e.Lblunite)
                .HasMaxLength(30)
                .HasColumnName("LBLUNITE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("users")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Email, "users_email_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("timestamp")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasColumnName("remember_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.Idutilisateur).HasName("PRIMARY");

            entity.ToTable("utilisateur");

            entity.Property(e => e.Idutilisateur).HasColumnName("IDUTILISATEUR");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .HasColumnName("NOM");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .HasColumnName("PRENOM");
            entity.Property(e => e.Telephone)
                .HasMaxLength(20)
                .HasColumnName("TELEPHONE");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Idzone).HasName("PRIMARY");

            entity.ToTable("zone");

            entity.Property(e => e.Idzone).HasColumnName("IDZONE");
            entity.Property(e => e.Lblzone)
                .HasMaxLength(50)
                .HasColumnName("LBLZONE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
