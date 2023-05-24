using Horizon2000Rest.Entity.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Horizon2000Rest.Entity.Data
{
    /*DbContext class that represents the database context
     It serves as a bridge between the application and the database,
     providing access to the database and the ability to query and manipulate data.*/
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        /*DbSet properties representing database tables
        Represents a table in the database for storing each table*/
        #region DBSet

        public virtual DbSet<AdvertDbo> Adverts { get; set; }
        public virtual DbSet<BookingDbo> Bookings { get; set; }
        public virtual DbSet<ClientDbo> Clients { get; set; }
        public virtual DbSet<ParentCourseDbo> ParentCourses { get; set; }
        public virtual DbSet<CourseDbo> Courses { get; set; }
        public virtual DbSet<ProductDbo> Products { get; set; }
        public virtual DbSet<ProductCategoryDbo> ProductCategories { get; set; }
        public virtual DbSet<RepairDbo> Repairs { get; set; }
        public virtual DbSet<RoleDbo> Roles { get; set; }
        public virtual DbSet<ScheduleDbo> Schedules { get; set; }
        public virtual DbSet<ScrollingTextDbo> ScrollingTexts { get; set; }
        public virtual DbSet<StudentDbo> Students { get; set; }
        public virtual DbSet<StudentCourseSkillCardDbo> StudentCourseSkillCards { get; set; }
        public virtual DbSet<UserDbo> Users { get; set; }
        public virtual DbSet<UserRoleDbo> UserRoles { get; set; }
        public virtual DbSet<UserSessionDbo> UserSessions { get; set; }

        #endregion

        /*Configures the database connection and options
          This method is called when the database is being configured
          It is used to configure the database provider and other options*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*Here, you would typically specify the database provider and connection string
            For example, if you're using SQL Server:
             optionsBuilder.UseSqlServer("YourConnectionString");

            In this case, the database provider and connection string are provided externally
             through the DbContextOptions parameter in the constructor, so no configuration is needed here.*/

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=192.168.1.18;Initial Catalog=Horizon2000Martin;User ID=horizonUser;Password=Horizon1234!!;TrustServerCertificate=True;");
        }

        /* the database model
         This method is called when the model for the database is being created
         It is used to configure the entity classes and their relationships to create the database schema*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*In this method, you configure the database schema using a fluent API
            You define the tables, their columns, relationships, and seed data.

             Here, you would typically define the mappings between entity classes and database tables,
             specify primary keys, foreign keys, indexes, and other constraints.

             In this code snippet, we see the modelBuilder being used to define seed data for various entities.
             Seed data represents initial data that is inserted into the database when it is created or migrated.*/

            #region Relationship configuration for tables entity

            //Relationship configuration for ParentCourseDbo entity
            modelBuilder.Entity<ParentCourseDbo>(pc =>
            {
                pc.HasMany(c => c.Courses) //specifies that a ParentCourseDbo can have multiple CourseDbo entities associated with it.
                    .WithOne(c => c.ParentCourse) //indicates that a CourseDbo entity has a reference to its parent ParentCourseDbo.
                    .HasForeignKey(c => c.ParentCourseId); //specifies that the foreign key property in the CourseDbo entity for the relationship is ParentCourseId.
                pc.HasMany(sc => sc.StudentCourseSkillCards) // states that a ParentCourseDbo can have multiple StudentCourseSkillCardDbo entities associated with it.
                    .WithOne(sc => sc.ParentCourse) //indicates that a StudentCourseSkillCardDbo entity has a reference to its parent ParentCourseDbo.
                    .HasForeignKey(sc => sc.ParentCourseID); //specifies that the foreign key property in the StudentCourseSkillCardDbo entity for the relationship is ParentCourseID.
            });

            // Relationship configuration for BookingDbo entity
            modelBuilder.Entity<BookingDbo>(b =>
            {
                b.HasOne(s => s.Schedule)
                    .WithMany(s => s.Bookings)
                    .HasForeignKey(b => b.ScheduleId);
                b.HasOne(st => st.Student)
                    .WithMany(st => st.Bookings)
                    .HasForeignKey(b => b.StudentId);
            });

            // Relationship configuration for CourseDbo entity
            modelBuilder.Entity<CourseDbo>(c =>
            {
                c.HasOne(p => p.ParentCourse)
                    .WithMany(pc => pc.Courses)
                    .HasForeignKey(c => c.ParentCourseId);
            });

            // Relationship configuration for ProductDbo entity
            modelBuilder.Entity<ProductDbo>(p =>
            {
                p.HasOne(pc => pc.ProductCategory)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryID);
            });

            // Relationship configuration for RepairDbo entity
            modelBuilder.Entity<RepairDbo>(r =>
            {
                r.HasOne(c => c.Client)
                    .WithMany(c => c.Repairs)
                    .HasForeignKey(r => r.ClientId);
            });

            // Relationship configuration for ScheduleDbo entity
            modelBuilder.Entity<ScheduleDbo>(s =>
            {
                s.HasOne(c => c.Course)
                    .WithMany(c => c.Schedules)
                    .HasForeignKey(s => s.CourseId);
            });

            // Relationship configuration for StudentCourseSkillCardDbo entity
            modelBuilder.Entity<StudentCourseSkillCardDbo>(sc =>
            {
                sc.HasOne(p => p.ParentCourse)
                    .WithMany(pc => pc.StudentCourseSkillCards)
                    .HasForeignKey(sc => sc.ParentCourseID);
                sc.HasOne(s => s.Student)
                    .WithMany(st => st.StudentCourseSkillCard)
                    .HasForeignKey(sc => sc.StudentID);
            });

            // Relationship configuration for UserDbo entity
            modelBuilder.Entity<UserDbo>(u =>
            {
                u.HasMany(ur => ur.UserRoles)
                    .WithOne(ur => ur.User)
                    .HasForeignKey(ur => ur.UserId);
            });

            // Relationship configuration for UserRoleDbo entity
            modelBuilder.Entity<UserRoleDbo>(ur =>
            {
                ur.HasOne(u => u.User)
                    .WithMany(u => u.UserRoles)
                    .HasForeignKey(ur => ur.UserId);
                ur.HasOne(r => r.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId);
            });

            // Relationship configuration for UserSessionDbo entity
            modelBuilder.Entity<UserSessionDbo>(us =>
            {
                us.HasOne(u => u.User)
                    .WithMany(u => u.UserSessions)
                    .HasForeignKey(us => us.UserId);


            });

            #endregion

            #region SeedData
            // Adding seed data for ParentCourseDbo entity
            #region Parent Courses
            modelBuilder.Entity<ParentCourseDbo>(pc => //configures the ParentCourseDbo entity using the modelBuilder instance. Inside the configuration, we define the seed data for the entity.
            {
                pc.HasData( //specifies that the entity should have seed data. We pass a new instance of ParentCourseDbo as the argument, which represents the data to be seeded.
                    new ParentCourseDbo //creates a new instance of ParentCourseDbo with the following properties:
                    {
                        //sets the row property of the ParentCourseDbo entity.
                        ID = 2,
                        Name = "ECDL Base & Standard",
                        ImagePath = "C:\\Images\\ECDL_logo.png",
                        IsActive = false,
                        DateCreated = DateTime.Now,
                    }); ;
            });

            modelBuilder.Entity<ParentCourseDbo>(pc =>
            {
                pc.HasData(
                    new ParentCourseDbo
                    {
                        ID = 4,
                        Name = "ECDL Advanced",
                        ImagePath = "C:\\Images\\ECDL_Logo.png",
                        IsActive = true,
                        DateCreated = DateTime.Now,
                    }); ;
            });

            modelBuilder.Entity<ParentCourseDbo>(pc =>
            {
                pc.HasData(
                    new ParentCourseDbo
                    {
                        ID = 5,
                        Name = "Matsec",
                        ImagePath = "C:\\Images\\Matsec.png",
                        IsActive = true,
                        DateCreated = DateTime.Now,
                    }); ;
            });

            modelBuilder.Entity<ParentCourseDbo>(pc =>
            {
                pc.HasData(
                    new ParentCourseDbo
                    {
                        ID = 6,
                        Name = "ICDL",
                        ImagePath = "C:\\\\Images\\icdl_logo.png",
                        IsActive = false,
                        DateCreated = DateTime.Now,
                    }); ;
            });
            #endregion

            // Adding seed data for ProductCategory entity
            #region ProductCategories
            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1,
                    Name = "Mice",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 2,
                    Name = "Joysticks",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 3,
                    Name = "Cables",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 4,
                    Name = "Storage Media",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 5,
                    Name = "Routers",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 6,
                    Name = "UPS",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 7,
                    Name = "Hubs",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1002,
                    Name = "Mice",
                    DateCreated = DateTime.UtcNow,
                    IsActive = false,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1003,
                    Name = "Mice",
                    DateCreated = DateTime.UtcNow,
                    IsActive = false,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1004,
                    Name = "Mice",
                    DateCreated = DateTime.UtcNow,
                    IsActive = false,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1005,
                    Name = "Laptops",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1006,
                    Name = "Towers (CPU)",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ProductCategoryDbo>(pc =>
            {
                pc.HasData(new ProductCategoryDbo
                {
                    ID = 1007,
                    Name = "Tablets",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            #endregion

            // Adding seed data for RoleDbo entity
            #region Roles

            modelBuilder.Entity<RoleDbo>(r =>
            {
                r.HasData(new RoleDbo
                {
                    ID = 1,
                    Name = "Admin"
                });
            });

            modelBuilder.Entity<RoleDbo>(r =>
            {
                r.HasData(new RoleDbo
                {
                    ID = 2,
                    Name = "User"
                });
            });


            #endregion

            // Adding seed data for ScrollingTextDbo entity
            #region ScrollingText

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1,
                    ScrollText = "Website still in progress...",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 2,
                    ScrollText = "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020 ",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 3,
                    ScrollText = "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020; A+Computer Technician starting on 3rd November 2020.......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com ",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 4,
                    ScrollText = "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020; A+Computer Technician starting on 3rd November 2020.......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com ",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 5,
                    ScrollText = "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020; A+Computer Technician starting on 3rd November 2020.......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com ",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 6,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com ",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 7,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com ",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 8,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We wish a Happy New Year 2021 for all our customers, please note that we are operating in full at 94, Triq De Rohan, Haz-Zebbug",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 9,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We wish a Happy New Year 2021 for all our customers, please note that we are operating in full at 94, Triq De Rohan, Haz-Zebbug",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1008,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  94, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug)",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1009,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  94, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1010,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  94, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1011,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1012,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com      HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1013,
                    ScrollText = "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1014,
                    ScrollText = "New courses ICDL Standard and ICDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm                      STARTING ON 16/08/2022 ICDL Advanced course Booking open",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 1015,
                    ScrollText = "New courses ICDL Standard and ICDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm                      STARTING ON 16/08/2022 ICDL Advanced course Booking open",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });

            modelBuilder.Entity<ScrollingTextDbo>(st =>
            {
                st.HasData(new ScrollingTextDbo
                {
                    ID = 2014,
                    ScrollText = "New courses ICDL Standard and ICDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm         BACK TO SCHOOL Winter Schedule lessons NOW AVAILABLE.......BOOK NOW",
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                });
            });


            #endregion

            // Adding seed data for UserDbo entity
            #region Users

            modelBuilder.Entity<UserDbo>().HasData(
                new UserDbo
                {
                    ID = 2,
                    Name = "Martin",
                    Surname = "Sultana",
                    Username = "MSULTANA",
                    Email = "horizon2000computers@gmail.com",
                    Password = "5F7C6C6AEC4B3C1930C473E2FAB6FA2450165F6BBBE4859698682C7670FC8DFDCE560CB51CCD07807F79F3AFB4AE87E5B2C6D2AFB941BE4DB985D1840FC7E05B",
                    DateRegistered = DateTime.Now,
                    IsActive = false
                });

            modelBuilder.Entity<UserDbo>().HasData(
                new UserDbo
                {
                    ID = 3,
                    Name = "Antoine",
                    Surname = "Schembri",
                    Username = "antoine",
                    Email = "horizon2000support@gmail.com",
                    Password = "69C06F6AAC655F931E600F78BB2A6DF3DF6FBF782E074C0880137AC17BA50FBD7E8D50FF15698BD70A76B65BA6BC18EB523D2BA6815F8AF1B18E5E4DF976AA2E",
                    DateRegistered = DateTime.Now,
                    IsActive = true
                });

            modelBuilder.Entity<UserDbo>().HasData(
                new UserDbo
                {
                    ID = 1002,
                    Name = "Martin",
                    Surname = "Sultana",
                    Username = "SultanaM",
                    Email = "horizon2000computers@gmail.com",
                    Password = "E2DCA7EA23086019C94DEDB30BC3A262BD23B3DBE124FB828E144DDEC0C6F6CC7A139156EEB43EC4A0CA50093B9C90C9449C6ECE2AE5DA11898F280484151A97",
                    DateRegistered = DateTime.Now,
                    IsActive = true
                });

            modelBuilder.Entity<UserDbo>().HasData(
                new UserDbo
                {
                    ID = 1003,
                    Name = "Abigail",
                    Surname = "Sultana",
                    Username = "sales",
                    Email = "horizon2000sales@gmail.com",
                    Password = "17B510A656C9B8D9A0FBF14172FE35E2CC18428D4DA605AA1F8BD1FC4D6F33828F817E977D832ED78D32D9057B6737113017B0BA03061DE341ED8691F1A14DBE",
                    DateRegistered = DateTime.Now,
                    IsActive = false
                });


            #endregion

            // Adding seed data for UserRoleDbo entity
            #region UserRoles

            modelBuilder.Entity<UserRoleDbo>(u =>
            {
                u.HasData(new UserRoleDbo
                {
                    ID = 2,
                    DateCreated = DateTime.Now,
                    IsActive = false,

                    UserId = 2,
                    RoleId = 1
                });
            });

            modelBuilder.Entity<UserRoleDbo>(u =>
            {
                u.HasData(new UserRoleDbo
                {
                    ID = 3,
                    DateCreated = DateTime.Now,
                    IsActive = true,

                    UserId = 3,
                    RoleId = 1
                });
            });

            modelBuilder.Entity<UserRoleDbo>(u =>
            {
                u.HasData(new UserRoleDbo
                {
                    ID = 1002,
                    DateCreated = DateTime.Now,
                    IsActive = true,

                    UserId = 1002,
                    RoleId = 1
                });
            });

            modelBuilder.Entity<UserRoleDbo>(u =>
            {
                u.HasData(new UserRoleDbo
                {
                    ID = 1003,
                    DateCreated = DateTime.Now,
                    IsActive = true,

                    UserId = 1003,
                    RoleId = 1
                });
            });


            #endregion

            #endregion

            #region Seed data TEST

            // Seed data for Roles

            //modelBuilder.Entity<RoleDbo>().HasData(
            //    new RoleDbo { ID = 1, Name = "Test Role" }
            //);

            // Seed data for Users

            //modelBuilder.Entity<UserDbo>().HasData(
            //    new UserDbo
            //    {
            //        ID = 1,
            //        Name = "name",
            //        Surname = "surname",
            //        Username = "user",
            //        Email = "email@email.com",
            //        Password = "password",
            //        DateRegistered = DateTime.Now,
            //        Active = true,
            //    }
            //);

            // Seed data for UserRoles

            //modelBuilder.Entity<UserRoleDbo>().HasData(
            //    new UserRoleDbo
            //    {
            //        ID = 1,
            //        RoleId = 1,
            //        UserId = 1,
            //        DateCreated = DateTime.Now,
            //        Active = true
            //    }
            //);

            // Seed data for ParentCourses

            //modelBuilder.Entity<ParentCourseDbo>().HasData(
            //    new ParentCourseDbo
            //    {
            //        ID = 1,
            //        Name = "parentcourse",
            //        ImagePath = "imagepath",
            //        IsActive = true,
            //        TestConditions = "regular",
            //        SkillCardCost = 2
            //    }
            //);

            // Seed data for Adverts

            //modelBuilder.Entity<AdvertDbo>().HasData(
            //    new AdvertDbo
            //    {
            //        ID = 1,
            //        Path = "test path",
            //        DateCreated = DateTime.Now,
            //        IsActive = true
            //    }
            //);

            // Seed data for Courses

            //modelBuilder.Entity<CourseDbo>().HasData(
            //    new CourseDbo
            //    {
            //        ID = 1,
            //        Name = "Test",
            //        Description = "Test",
            //        NormalHour = 1,
            //        NormalPrice = 1,
            //        RapidHour = 1,
            //        RapidPrice = 1,
            //        IsActive = true,
            //        DateCreated = DateTime.UtcNow,
            //        ImagePath = "path",
            //        ParentCourseId = 1
            //    }
            //);



            // Seed data for ProductCategories

            //modelBuilder.Entity<ProductCategoryDbo>().HasData(
            //    new ProductCategoryDbo
            //    {
            //        ID = 1,
            //        Name = "name",
            //        DateCreated = DateTime.Now,
            //        IsActive = true,
            //    }
            //);



            // Seed data for Products

            //modelBuilder.Entity<ProductDbo>().HasData(
            //    new ProductDbo
            //    {
            //        ID = 1,
            //        Name = "Test",
            //        Description = "Test",
            //        CategoryID = 1,
            //        Price = 1,
            //        Image = "Image",
            //        DateCreated = DateTime.Now,
            //        Active = false,
            //    }
            //);

            // Seed data for Student

            //modelBuilder.Entity<StudentDbo>().HasData(
            //    new StudentDbo
            //    {
            //        ID = 1,
            //        IdCard = "Test",
            //        Title = "Test",
            //        Name = "Test",
            //        Surname = "Test",
            //        Address1 = "Test",
            //        Address2 = "Test",
            //        City = "Test",
            //        Email = "Test",
            //        ContactNo = "621879632",
            //        DateOfBirth = DateTime.Now,
            //        DateCreated = DateTime.Now,
            //        IsActive = false,
            //    }
            //);


            // Seed data for StudentCourseSkillCards

            //modelBuilder.Entity<StudentCourseSkillCardDbo>().HasData(
            //    new StudentCourseSkillCardDbo
            //    {
            //        ID = 1,
            //        ParentCourseID = 1,
            //        StudentID = 1,
            //        SkillCard = "",
            //        DateCreated = DateTime.Now,
            //        Active = false
            //    }
            //);

            #endregion
        }

    }
}
