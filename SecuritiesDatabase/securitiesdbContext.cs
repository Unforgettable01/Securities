using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class securitiesdbContext : DbContext
    {
        public securitiesdbContext()
        {
        }

        public securitiesdbContext(DbContextOptions<securitiesdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Bag> Bag { get; set; }
        public virtual DbSet<BagSecurities> BagSecurities { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ContractBuy> ContractBuy { get; set; }
        public virtual DbSet<ContractBuySale> ContractBuySale { get; set; }
        public virtual DbSet<Emitent> Emitent { get; set; }
        public virtual DbSet<PaymentContractBuy> PaymentContractBuy { get; set; }
        public virtual DbSet<PaymentContractBuySale> PaymentContractBuySale { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Security> Security { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=92.252.241.236;Port=5432;Database=securitiesdb;Username=postgres;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("agent");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 100000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(250);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Bag>(entity =>
            {
                entity.ToTable("bag");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<BagSecurities>(entity =>
            {
                entity.ToTable("bagSecurities");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BagId).HasColumnName("bagId");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.SecuritiesId).HasColumnName("securitiesId");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.BagSecurities)
                    .HasForeignKey(d => d.BagId)
                    .HasConstraintName("bagId");

                entity.HasOne(d => d.Securities)
                    .WithMany(p => p.BagSecurities)
                    .HasForeignKey(d => d.SecuritiesId)
                    .HasConstraintName("securitiesId");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 100000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(250);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(250);

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("passportNumber")
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ContractBuy>(entity =>
            {
                entity.ToTable("contractBuy");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(250);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ContractBuy)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("requestId");
            });

            modelBuilder.Entity<ContractBuySale>(entity =>
            {
                entity.ToTable("contractBuySale");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(250);

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ContractBuySale)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("requestId");
            });

            modelBuilder.Entity<Emitent>(entity =>
            {
                entity.ToTable("emitent");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PaymentContractBuy>(entity =>
            {
                entity.ToTable("paymentContractBuy");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ContractBuyId).HasColumnName("contractBuyId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");

                entity.HasOne(d => d.ContractBuy)
                    .WithMany(p => p.PaymentContractBuy)
                    .HasForeignKey(d => d.ContractBuyId)
                    .HasConstraintName("contractBuyId");
            });

            modelBuilder.Entity<PaymentContractBuySale>(entity =>
            {
                entity.ToTable("paymentContractBuySale");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ContractBuySaleId).HasColumnName("contractBuySaleId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");

                entity.HasOne(d => d.ContractBuySale)
                    .WithMany(p => p.PaymentContractBuySale)
                    .HasForeignKey(d => d.ContractBuySaleId)
                    .HasConstraintName("contractBuySaleId");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("request");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.BagId).HasColumnName("bagId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("money");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("agentId");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.BagId)
                    .HasConstraintName("bagId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("clientId");
            });

            modelBuilder.Entity<Security>(entity =>
            {
                entity.ToTable("security");

                entity.Property(e => e.Id)
                    .HasIdentityOptions(null, null, null, 1000000L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BuyPrice)
                    .HasColumnName("buyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.EmitentId).HasColumnName("emitentId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.SalePrice)
                    .HasColumnName("salePrice")
                    .HasColumnType("money");

                entity.HasOne(d => d.Emitent)
                    .WithMany(p => p.Security)
                    .HasForeignKey(d => d.EmitentId)
                    .HasConstraintName("emitentId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
