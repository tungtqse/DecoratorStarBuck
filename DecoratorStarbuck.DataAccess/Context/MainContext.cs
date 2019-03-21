using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarbuck.DataAccess.Context
{
    public class MainContext : DbContext
    {
        public MainContext(string connectionStringName) : base(connectionStringName) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

        #region
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Types<DataBaseModel>().Configure(c =>
            {
                c.HasKey(p => p.Id);
                c.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                c.Property(p => p.StatusId).IsRequired().HasMaxLength(10);
                c.Property(p => p.CreatedDate).IsRequired();
                c.Property(p => p.CreatedBy).IsRequired();
                c.Property(p => p.ModifiedDate).IsRequired();
                c.Property(p => p.ModifiedBy).IsRequired();
            });

            modelBuilder.Entity<UserProfile>()
                .HasMany(s => s.Roles)
                .WithMany(c => c.UserProfiles)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserProfile_Id");
                    cs.MapRightKey("Role_Id");
                    cs.ToTable("UserProfileRole");
                });

            modelBuilder.Entity<UserProfile>()
          .HasMany(s => s.CostCenters)
          .WithMany(c => c.UserProfiles)
          .Map(cs =>
          {
              cs.MapLeftKey("UserProfile_Id");
              cs.MapRightKey("CostCenter_Id");
              cs.ToTable("UserProfileCostCenter");
          });

            modelBuilder.Entity<UserProfile>()
               .HasMany(s => s.OpuList)
               .WithMany(c => c.UserProfiles)
               .Map(cs =>
               {
                   cs.MapLeftKey("UserProfile_Id");
                   cs.MapRightKey("Opu_Id");
                   cs.ToTable("UserProfileOpu");
               });



            modelBuilder.Entity<FavoriteProduct>()
                .HasKey(x => new { x.UserId, x.ProductId })
                .HasRequired(x => x.ProductBase).WithMany(m => m.FavoriteProducts).HasForeignKey(x => x.ProductId);


            modelBuilder.Entity<FavoriteProduct>()
                .HasKey(x => new { x.UserId, x.ProductId })
                .HasRequired(x => x.UserProfile).WithMany(m => m.FavoriteProducts).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Announcement>()
            .HasOptional(p => p.SomsImage).WithMany(x => x.Announcements).HasForeignKey(p => p.BackgroundPicId);

            modelBuilder.Entity<OrganizationUnit>()
                   .HasOptional(c => c.Parent)
                   .WithMany()
                   .HasForeignKey(c => c.ParentOid);
        }
        */
        #endregion
    }
}
