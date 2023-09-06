using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BankAppInlämming.Models
{
    public partial class BankAppContext : DbContext
    {
        public BankAppContext()
        {
        }

        public BankAppContext(DbContextOptions<BankAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=BankApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Balance).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.CustumerId).HasColumnName("CustumerID");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_Account_AccountType");

                entity.HasOne(d => d.Custumer)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CustumerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Customer");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.Property(e => e.Rent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Namn)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.ToTable("Loan");

                entity.Property(e => e.Amount).HasColumnType("decimal(13, 2)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Loan_Account");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.AccountIdto).HasColumnName("AccountIDTo");

                entity.Property(e => e.Amount).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.AccountIdFromNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountIdFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
