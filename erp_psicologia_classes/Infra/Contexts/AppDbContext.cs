using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Infra.Contexts
{
    public class AppDbContext : DbContext
    {
        #region [DBSETS]
        public DbSet<Person> Peoples { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Psychologist> Psychologists { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Configuration> Configurations { get; set; }

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region [PERSON]
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.OwnsOne(e => e.Name, name =>
                {
                    name.Property(n => n.Value)
                        .HasColumnName("Name")
                        .IsRequired();
                });
                entity.OwnsOne(e => e.Email, email =>
                {
                    email.Property(e => e.Value)
                        .HasColumnName("Email")
                        .IsRequired();
                });
                entity.OwnsOne(e => e.Phone, phone =>
                {
                    phone.Property(p => p.Value)
                        .HasColumnName("Phone")
                        .IsRequired();
                });
                entity.OwnsOne(e => e.Cpf, cpf =>
                {
                    cpf.Property(c => c.Value)
                        .HasColumnName("Cpf")
                        .IsRequired();
                });
                entity.Property(e => e.Description)
                .HasMaxLength(500); 
            });
            #endregion
            #region [PATIENT]
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Person)
                      .WithOne()
                      .HasForeignKey<Patient>(e => e.PersonId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion
            #region [PSYCHOLOGIST]
            modelBuilder.Entity<Psychologist>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Person)
                      .WithOne()
                      .HasForeignKey<Psychologist>(e => e.PersonId)
                      .OnDelete(DeleteBehavior.Restrict); // Evita cascata perigosa

                entity.OwnsOne(e => e.LicenseNumber, licenseNumber =>
                {
                    licenseNumber.Property(l => l.Value)
                                 .HasColumnName("LicenseNumber")
                                 .IsRequired();
                });

                entity.Property(e => e.Approach)
                      .HasConversion<int>()
                      .IsRequired();

                entity.Property(e => e.Password)
                      .IsRequired()
                      .HasMaxLength(100); 
            });

            #endregion
            #region [SCHEDULE]
            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Date)
                      .IsRequired();

                entity.Property(e => e.Start)
                      .IsRequired();

                entity.Property(e => e.End)
                      .IsRequired();

                entity.HasOne(e => e.Psychologist)
                      .WithMany()
                      .HasForeignKey(e => e.PsychologistId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Patient)
                      .WithMany()
                      .HasForeignKey(e => e.PatientId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
            #endregion
            #region [SESSION]
            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Description)
                      .HasMaxLength(500);

                entity.Property(e => e.Feedback)
                      .IsRequired();

                entity.HasOne(e => e.Psychologist)
                      .WithMany()
                      .HasForeignKey(e => e.PsychologistId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Patient)
                      .WithMany()
                      .HasForeignKey(e => e.PatientId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Schedule)
                      .WithMany()
                      .HasForeignKey(e => e.ScheduleId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
            #endregion
            #region [CONFIGURATION]
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasMaxLength(500);
            });
            #endregion
            #region [PAYMENT]
            modelBuilder.Entity<Payment>(entity =>
            {
                modelBuilder.Entity<Payment>(entity =>
                {
                    entity.HasKey(e => e.Id);

                    entity.Property(e => e.Value)
                          .IsRequired()
                          .HasColumnType("decimal(10,2)");

                    entity.Property(e => e.Amount_Paid)
                          .IsRequired()
                          .HasColumnType("decimal(10,2)");

                    entity.Property(e => e.Date)
                          .IsRequired();

                    entity.Property(e => e.Paid)
                          .IsRequired();

                    entity.Property(e => e.Description)
                          .HasMaxLength(500);

                    entity.HasOne(e => e.Session)
                          .WithMany()
                          .HasForeignKey(e => e.SessionId)
                          .OnDelete(DeleteBehavior.Cascade);
                });
            });
            #endregion
        }
    }
}
