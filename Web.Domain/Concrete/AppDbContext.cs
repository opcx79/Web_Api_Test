﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.Domain.Abstracts;
using Web.Domain.Entities;

namespace Web.Domain.Concrete
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext() : base("AppDbContext") { }

        static AppDbContext()
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Video>().HasMany(x => x.Tags).WithMany(x => x.Videos)
                .Map(x => x.MapLeftKey("VideoID").MapRightKey("TagID").ToTable("VideoTags"));

            modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(x => x.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims").Property(x => x.Id).HasColumnName("UserClaimId");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").Property(x => x.Id).HasColumnName("RoleName");
        }

        public static AppDbContext Create() => new AppDbContext();

        public override Task<int> SaveChangesAsync()
        {
            ImplementAuditableEntity();
            return base.SaveChangesAsync();
        }

        void ImplementAuditableEntity()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditable
                && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in modifiedEntries)
            {
                IAuditable entity = entry.Entity as IAuditable;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.Now;
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = "TestUser"; //identityName;
                        entity.DateCreated = now;
                    }
                    else
                    {
                        Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        Entry(entity).Property(x => x.DateCreated).IsModified = false;
                    }

                    entity.UpdatedBy = "TestUser"; //identityName;
                    entity.UpdatedDate = now;
                }
            }
        }
    }
}