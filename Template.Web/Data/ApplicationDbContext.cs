using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template.Model.Models.Admin;

namespace Template.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            CreateTables(builder);
        }

        #region Private Methods
        private void CreateTables(ModelBuilder builder)
        {
            builder.Entity<UserModel>(entity =>
            {
                entity.ToTable(name: "TB_USER");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "TB_ROLE");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("TB_USER_ROLE");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("TB_USER_CLAIMS");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("TB_USER_LOGIN");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("TB_ROLE_CLAIMS");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("TB_USER_TOKENS");
            });
        }
        #endregion Private Methods
    }
}
