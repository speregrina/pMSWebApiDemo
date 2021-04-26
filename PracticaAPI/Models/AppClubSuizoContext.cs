using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class AppClubSuizoContext : DbContext
    {
        public AppClubSuizoContext()
        {
        }

        public AppClubSuizoContext(DbContextOptions<AppClubSuizoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatLanguage> CatLanguages { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Due> Dues { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<FileRepository> FileRepositories { get; set; }
        public virtual DbSet<ImagesGallery> ImagesGalleries { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<LabelType> LabelTypes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationType> NotificationTypes { get; set; }
        public virtual DbSet<PaymentReservation> PaymentReservations { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionReservation> PromotionReservations { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Room_tmp> Room_tmps { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Site_tmp> Site_tmps { get; set; }
        public virtual DbSet<TypeDue> TypeDues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=TSW-DVP;Database=TSW_DESARROLLO_ClientCustom;user=usr_AppClubSuizo;password=%4pC1u6$3003@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CatLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageID)
                    .HasName("PK__CatLangu__B938558B47E9B3AE");

                entity.ToTable("CatLanguage", "AppClubSuizo");

                entity.Property(e => e.LanguageID)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.ToTable("Destination", "AppClubSuizo");

                entity.HasIndex(e => e.Name, "UQ__Destinat__737584F64E96B13D")
                    .IsUnique();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageID)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Due>(entity =>
            {
                entity.ToTable("Due", "AppClubSuizo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.ToTable("Favorite", "AppClubSuizo");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageID)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FileRepository>(entity =>
            {
                entity.ToTable("FileRepository", "AppClubSuizo");

                entity.Property(e => e.FileRepositoryID).ValueGeneratedNever();

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordID)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UrlFile)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImagesGallery>(entity =>
            {
                entity.ToTable("ImagesGallery", "AppClubSuizo");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.subModule)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance", "AppClubSuizo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("Label", "AppClubSuizo");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.KeyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Label1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Label");

                entity.Property(e => e.LanguageID)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabelType>(entity =>
            {
                entity.ToTable("LabelType", "AppClubSuizo");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification", "AppClubSuizo");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.DateShow).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.LinkedTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.ToTable("NotificationType", "AppClubSuizo");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageID)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NotificationType");
            });

            modelBuilder.Entity<PaymentReservation>(entity =>
            {
                entity.ToTable("PaymentReservation", "AppClubSuizo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatePayment).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.NumberPayment).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.ToTable("Promotion", "AppClubSuizo");

                entity.Property(e => e.PromotionID).ValueGeneratedNever();

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PromotionReservation>(entity =>
            {
                entity.ToTable("PromotionReservation", "AppClubSuizo");
            });

            modelBuilder.Entity<PropertyType>(entity =>
            {
                entity.ToTable("PropertyType", "AppClubSuizo");

                entity.Property(e => e.PropertyType1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PropertyType");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation", "AppClubSuizo");

                entity.Property(e => e.ReservationID).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.UrlDocument)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Room", "AppClubSuizo");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrlMain)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Occupancy).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Room_tmp>(entity =>
            {
                entity.HasKey(e => new { e.RoomID, e.SiteID, e.RoomTypeID })
                    .HasName("Room_PK_tmp");

                entity.ToTable("Room_tmp", "AppClubSuizo");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ImgName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrlMain)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Occupancy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RoomType)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => new { e.SiteID, e.LanguageID });

                entity.ToTable("Site", "AppClubSuizo");

                entity.Property(e => e.LanguageID)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAllInclusive).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Site_tmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Site_tmp", "AppClubSuizo");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CP)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageID)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Long)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.country)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeDue>(entity =>
            {
                entity.HasKey(e => e.TypeDuesID)
                    .HasName("PK__TypeDues__D420395E7E45C45F");

                entity.ToTable("TypeDues", "AppClubSuizo");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.TypeDues)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserNameUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
