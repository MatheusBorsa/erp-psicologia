using erp_psicologia_classes.Domain.Entities;
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
        public DbSet<Person> people { get; set; }

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

            });
            #endregion
        }
    }
}
