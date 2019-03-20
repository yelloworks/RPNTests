using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RPNTests.Models.Entities;

namespace RPNTests.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveTest>().HasKey(p => new {p.UserTestId, p.QuestionNumber});

            modelBuilder.Entity<ActiveTest>().HasRequired<UserTest>(p => p.CurrentUserTest).WithMany(p => p.ActiveTests)
                .HasForeignKey<int>(p => p.UserTestId);
            modelBuilder.Entity<ActiveTest>().HasRequired<Question>(p => p.CurrentQuestion).WithMany(p => p.ActiveTests)
                .HasForeignKey<int>(p => p.QuestionId);

            modelBuilder.Entity<Answer>().HasRequired<Question>(p => p.CurrentQuestion).WithMany(p => p.Answers)
                .HasForeignKey<int>(p => p.QuestionId);

            //modelBuilder.Entity<RightAnswer>().HasRequired<Question>(p => p.CurrentQuestion).WithMany(p => p.RightAnswers)
            //    .HasForeignKey<int>(p => p.QuestionId);
            modelBuilder.Entity<RightAnswer>().HasRequired<Answer>(p => p.CurrentAnswer).WithMany(p => p.RightAnswers)
                .HasForeignKey<int>(p => p.AnswerId);

            modelBuilder.Entity<Test>().HasRequired<TestType>(p => p.CurrentTestType).WithMany(p => p.Tests)
                .HasForeignKey<int>(p => p.TypeId);

            modelBuilder.Entity<TestQuestion>().HasRequired<Test>(p => p.CurrentTest).WithMany(p => p.TestQuestions)
                .HasForeignKey<int>(p => p.TestId);
            modelBuilder.Entity<TestQuestion>().HasRequired<Question>(p => p.CurrentQuestion).WithMany(p => p.TestQuestions)
                .HasForeignKey<int>(p => p.QuestionId);

            modelBuilder.Entity<UserTest>().HasRequired<Test>(p => p.CurrentTest).WithMany(p => p.UserTests)
                .HasForeignKey<int>(p => p.TestId);

            modelBuilder.Entity<UserTestAnswer>().HasRequired<UserTest>(p => p.CurrentUserTest)
                .WithMany(p => p.UserTestAnswers).HasForeignKey<int>(p => p.UserTestId);
            modelBuilder.Entity<UserTestAnswer>().HasRequired<Question>(p => p.CurrentQuestion)
                .WithMany(p => p.UserTestAnswers).HasForeignKey<int>(p => p.QuestionId);


                



            base.OnModelCreating(modelBuilder);
        }
    }
}