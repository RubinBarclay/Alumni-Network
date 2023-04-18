using Alumni_Network.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Alumni_Network.Models
{
    public class AlumniDbContext : DbContext
    {
        public AlumniDbContext(DbContextOptions<AlumniDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configures the self referencing one-to-many relationship for Post
            modelBuilder.Entity<Post>()
                .HasOne(e => e.ReplyParent)
                .WithMany(e => e.Replies)
                .HasForeignKey(e => e.ReplyParentId)
                .IsRequired(false);

            // Seed data for User
            modelBuilder.Entity<User>().HasData
            (
                // Interests: Computer Science
                new User { Id = 1, Name = "John Doe", Sub = "df9ea233-b53d-4e1b-b155-258bbe7df862", PictureUrl = "https://randomuser.me/api/portraits/men/67.jpg", Status = "Comp sci student at the University of Washington", Bio = "I'm a student at the University of Washington.", FunFact = "I can solve a rubik's cube in less than 12 seconds" },
                // Interests: Psychology
                new User { Id = 2, Name = "Peter Olsson", Sub = "9d1278a9-05ed-4dc9-8a1f-ad4e1105c10b", PictureUrl = "https://randomuser.me/api/portraits/men/0.jpg", Status = "Learing how to analyze the mind", Bio = "Aspiring psychologist currently studing at the Stockholm University.", FunFact = "I like to eat cake in the shower" },
                // Interests: Psychology
                new User { Id = 3, Name = "Jane Federstone", Sub = "63d13f5d-8aa6-467e-986e-450f6e716f64", PictureUrl = "https://randomuser.me/api/portraits/women/27.jpg", Status = "Newly grad from the University of Ohio", Bio = "I'm a recent graduate from the University of Ohio.", FunFact = "I'm a huge fan of the Seattle Seahawks (and psychology)" },
                // Interests: Medicine, History
                new User { Id = 4, Name = "Axel Schwarzbergen", Sub = "827614eb-c54e-43ae-a637-27eb70e385a8", Status = "Slowly becoming a professional MD", FunFact = "I secretely LOVE history hehe" },
                // Interests: Medicine
                new User { Id = 5, Name = "Sara Svensson", Sub = "48ae61f5-5dc8-4058-85b6-887ac20e5b03", Status = "Interning as a nurse at the Reykjavik University Hospital" },
                // Interests: Art, Other
                new User { Id = 6, Name = "Harry McPottson", Sub = "c0a72b96-f65c-473e-8ff1-f89b1097a937", PictureUrl = "https://randomuser.me/api/portraits/men/80.jpg", Status = "Studying magic at Hogwarts", Bio = "Destined to save the world or whatever but right now I kinda just like studying and chilling with my boy Ron." },
                // Interests: Biology
                new User { Id = 7, Name = "Alice Watson", Sub = "59207104-f1e4-4338-a507-bb217d223fbd", PictureUrl = "https://randomuser.me/api/portraits/women/72.jpg", Bio = "Researcher by day and hardcore gamer by night. But most of the time i just sit and stare at cells through a microscope." },
                // Interests: Economics
                new User { Id = 8, Name = "Jason Bilgums", Sub = "a0d48da1-29c5-4a03-9755-897fa2908da6", PictureUrl = "https://randomuser.me/api/portraits/men/89.jpg", Status = "Looking for something to do with a economics degree", Bio = "Recent Harvard Economics graduate who wasted his 20's studying 16 hours a day." },
                // Interests: Philosophy
                new User { Id = 9, Name = "Sally Parker", Sub = "67de4545-3904-4f6d-ad22-abff0fc51fc8", PictureUrl = "https://randomuser.me/api/portraits/women/50.jpg", Status = "Thinking very hard about something..." },
                // Interests: Computer Science, Economics
                new User { Id = 10, Name = "Jeffrey Thompson", Sub = "6c7fe842-2a02-4e03-88da-1892b91a797c", PictureUrl = "https://randomuser.me/api/portraits/men/3.jpg", Status = "Programming my own trading bot", Bio = "I'm a nerdy programmer with a big interest in finance and getting rich.", FunFact = "I made and $650 by selling my first app" },
                // Interests: Art
                new User { Id = 11, Name = "Lucy Kim", Sub = "39f957a0-aecc-4fc3-9445-ecd93ad2e6e6", PictureUrl = "https://randomuser.me/api/portraits/women/60.jpg", Status = "Currently painting a masterpiece", Bio = "There is nothing I love more than zoning out and mindlessly drawing for hours on end.", FunFact = "I paid off my student loans with weird art commissions" },
                // Interests: Mathematics
                new User { Id = 12, Name = "Muhammad Al-Salehi", Sub = "01f8e89d-ee69-4279-bd22-4b0afd9e8060", PictureUrl = "https://randomuser.me/api/portraits/men/53.jpg", Status = "Working on my own number theorem", Bio = "I've always problem solving and working on complicated problems. Hence I became a mathimatician." }
            );

            // Seed data for Group
            modelBuilder.Entity<Group>().HasData
            (
                new Group { Id = 1, Name = "Computer Science", Description = "Talk about anything and everything related to the amazing field of computer science!", IsPrivate = false },
                new Group { Id = 2, Name = "Psychology", Description = "Discuss the mind and how it works!", IsPrivate = false },
                new Group { Id = 3, Name = "Medicine", Description = "Share your experiences and knowledge about the medical field!", IsPrivate = false },
                new Group { Id = 4, Name = "Economics", Description = "Fun, interesting or even devastating topics about the world of economics. Anything goes!", IsPrivate = false },
                new Group { Id = 5, Name = "Biology", Description = "Share your knowledge about the amazing world of biology!", IsPrivate = false },
                new Group { Id = 6, Name = "Philosophy", Description = "Share your ideas and thoughts about the world of philosophy!", IsPrivate = false },
                new Group { Id = 7, Name = "Mathematics", Description = "Chat about your love for math with other geeky mathimaticians.", IsPrivate = false },
                new Group { Id = 8, Name = "History", Description = "Big history buff are you? Then this is the group for you!", IsPrivate = false },
                new Group { Id = 9, Name = "Art", Description = "For people interested in the art and similar creative fields.", IsPrivate = false },
                new Group { Id = 10, Name = "Other", Description = "Want to discuss something a little off-topic. Post it in here!", IsPrivate = false }
            );

            // Seed data for Post (top-level posts)
            modelBuilder.Entity<Post>().HasData
            (
                new Post { Id = 1, Title = "I'm going to start a new project. Any ideas?", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 1, TargetGroupId = 1 },
                new Post { Id = 2, Title = "How do I clean out this gunk from by beakers?", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 5, TargetGroupId = 7 },
                new Post { Id = 3, Title = "I genuinely believe the earth is flat", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 3, TargetGroupId = 6  },
                new Post { Id = 4, Title = "Tell me your top 3 historical figures and why", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 4, TargetGroupId = 8  },
                new Post { Id = 5, Title = "What is the meaning of life?", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 3, TargetGroupId = 6 },
                new Post { Id = 6, Title = "How does one learn how to draw?", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 6, TargetGroupId = 9 },
                new Post { Id = 7, Title = "My review of Harvards Economics program", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 8, TargetGroupId = 4 },
                new Post { Id = 8, Title = "Was Keynes a communist?", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 8, TargetGroupId = 4 },
                new Post { Id = 9, Title = "I flunked my philosophy exam...", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 9, TargetGroupId = 6 },
                new Post { Id = 10, Title = "Can anybody become a doctor?", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AuthorId = 9, TargetGroupId = 3 }
            );

            // Seed data for Post (replies)
            modelBuilder.Entity<Post>().HasData
            (
                new Post { Id = 11, Title = "Do you have any other interests?", Body = "The best way imo to start a new project and ACTUALLY FINISH IT, is by building a project that actually interests you. So try building a project that mixes in some other thing you're interested in.", AuthorId = 10, TargetGroupId = 1, ReplyParentId = 1 },
                new Post { Id = 12, Title = "Go see a therapist", Body = "You are delusional and need to seek medical attention ASAP", AuthorId = 4, TargetGroupId = 6, ReplyParentId = 3 },
                new Post { Id = 13, Title = "Here are my top 3", Body = "Ghandi, MLK and Nicola Tesla. Cus they are all dope af", AuthorId = 8, TargetGroupId = 8, ReplyParentId = 4 },
                new Post { Id = 14, Title = "Go fish", Body = "You're definitively not gonna find the answer some random internet forum lol", AuthorId = 9, TargetGroupId = 6, ReplyParentId = 5 },
                new Post { Id = 15, Title = "Interesting review!", Body = "Doubt I'll ever get in but these are some cool insights", AuthorId = 10, TargetGroupId = 6, ReplyParentId = 7 },
                new Post { Id = 16, Title = "Never give up", Body = "I have failed plenty of exams during my time at uni, just retake and study a little harder next time ;)", AuthorId = 2, TargetGroupId = 9, ReplyParentId = 9 },
                new Post { Id = 17, Title = "I guess but it's hard work", Body = "You don't have to be some kind of genius to become a doctor but it does take a very long time and a lot of studying.", AuthorId = 4, TargetGroupId = 3, ReplyParentId = 10 },
                new Post { Id = 18, Title = "Of course!", Body = "Despite what a lot of people think it's not that hard. I have talked to a lot of doctors that frankly aren't so bright", AuthorId = 5, TargetGroupId = 3, ReplyParentId = 10 }
            );

            // Seed data for linking table between Group and User
            modelBuilder.Entity<User>()
                .HasMany(e => e.Groups)
                .WithMany(u => u.Members)
                .UsingEntity<Dictionary<string, object>>
                (
                    "GroupUser",
                    r => r.HasOne<Group>().WithMany().HasForeignKey("GroupsId"),
                    l => l.HasOne<User>().WithMany().HasForeignKey("MembersId"),
                    je =>
                    {
                       je.HasKey("GroupsId", "MembersId");
                       je.HasData
                       (
                           new { GroupsId = 1, MembersId = 1 },
                           new { GroupsId = 2, MembersId = 2 },
                           new { GroupsId = 2, MembersId = 3 },
                           new { GroupsId = 3, MembersId = 4 },
                           new { GroupsId = 8, MembersId = 4 },
                           new { GroupsId = 3, MembersId = 5 },
                           new { GroupsId = 9, MembersId = 6 },
                           new { GroupsId = 10, MembersId = 6 },
                           new { GroupsId = 5, MembersId = 7 },
                           new { GroupsId = 4, MembersId = 8 },
                           new { GroupsId = 6, MembersId = 9 },
                           new { GroupsId = 1, MembersId = 10 },
                           new { GroupsId = 4, MembersId = 10 },
                           new { GroupsId = 9, MembersId = 11 },
                           new { GroupsId = 7, MembersId = 12 }
                       );
                    }
                );

            // Set default values for CreatedAt and UpdatedAt properties for seeded data
            modelBuilder.Entity<User>()
                .Property(p => p.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<User>()
                .Property(p => p.UpdatedAt)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Post>()
                .Property(p => p.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Post>()
                .Property(p => p.UpdatedAt)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Group>()
                .Property(p => p.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Group>()
                .Property(p => p.UpdatedAt)
                .HasDefaultValue(DateTime.Now);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && 
            (
                e.State == EntityState.Added || e.State == EntityState.Modified)
            );

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
