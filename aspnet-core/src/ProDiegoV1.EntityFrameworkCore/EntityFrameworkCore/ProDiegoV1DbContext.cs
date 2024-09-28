using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProDiegoV1.Authorization.Roles;
using ProDiegoV1.Authorization.Users;
using ProDiegoV1.MultiTenancy;
using ProDiegoV1.models;

namespace ProDiegoV1.EntityFrameworkCore
{
    public class ProDiegoV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProDiegoV1DbContext>
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<College> Colleges { get; set; }

        /* Define a DbSet for each entity of the application */

        public ProDiegoV1DbContext(DbContextOptions<ProDiegoV1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760

            modelBuilder.Entity<Student>(entity => {
                //configure PK
                entity.HasKey(student => student.Id);

                //configure one-to-many relationship
                entity.HasOne(student => student.College)
                .WithMany(college => college.Students)
                .HasForeignKey(student => student.CollegeId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<College>(entity =>{
                //configure PK
                entity.HasKey(college => college.Id);

                //Theres no need to configure relationship here bc it's already in Student
                //entity.HasMany(college => college.Students)
                //.WithOne(student => student.College);
            });
        }






    }
}
