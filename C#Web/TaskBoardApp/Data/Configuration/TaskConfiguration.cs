using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoardApp.Data.Configuration

{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public IdentityUser TestUser = GetUser();
        public Board OpenBoard = new Board()
        {
            Id = 1,
            Name = "Open"
        };
        public Board InProgressBoard = new Board()
        {
            Id = 2,
            Name = "In progress"
        };
        public Board DoneBoard = new Board()
        {
            Id = 3,
            Name = "Done"
        };


        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasOne(t => t.Board)
                  .WithMany(b => b.Tasks)
                  .HasForeignKey(t => t.BoardId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
        private IEnumerable<Task> SeedTasks {

            Task [] tasks = new Task[]
            {
                new Task()
{ 
        
}
            };
        }
        private static IdentityUser GetUser()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            var user = new IdentityUser() 
            {
                UserName = "test@softuni.bg",
                NormalizedUserName = "TEST@SOFTUNI.BG"
            };
            user.PasswordHash = hasher.HashPassword(user, "softuni");
            return user;
        }
        
    }
}
