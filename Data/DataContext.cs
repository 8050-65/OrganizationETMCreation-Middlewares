using Microsoft.EntityFrameworkCore;
using OrganizationETMCreation.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<TeamManager> teammanagers { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Manager> Managers { get; set; }


    //public Employee TeamManager { get; internal set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Team>()
            .HasMany(t => t.TeamMembers)
            .WithOne(tm => tm.Team)
            .HasForeignKey(tm => tm.TeamId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Employee>()
            //.HasKey(tm => tm.id)
            .HasMany(e => e.TeamMembers)
            .WithOne(tm => tm.Employee)
            .HasForeignKey(tm => tm.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TeamManager>()
            .HasKey(tm => tm.id);

        modelBuilder.Entity<TeamMember>()
            .HasKey(tm => new { tm.TeamId, tm.memberid }); 

        modelBuilder.Entity<Manager>()
           .HasKey(mn => mn.Id);

        modelBuilder.Entity<Member>()
            .HasKey(tb => tb.memberid); 
    }
}

















        // Specify composite key for TeamMember
        //modelBuilder.Entity<TeamMember>()
        //    .HasKey(tm => new { tm.TeamId, tm.EmployeeId });


        //// Ensure correct mapping
        //modelBuilder.Entity<TeamMember>()
        //    .Property(tm => tm.MemberId) 
        //    .HasColumnName("memberid");  // Match exact column name in database

        //modelBuilder.Entity<TeamMember>()
        //   .Ignore(tm => tm.MemberId);
        //modelBuilder.Entity<TeamManager>()
        //    .WithOne(tm => tm.Team)
        //    .HasForeignKey(tm => tm.TmemberId);

        //modelBuilder.Entity<TeamMember>()
        //    .HasKey(tm => new { tm.TeamId, tm.MemberId });

        //modelBuilder.Entity<TeamManager>()
        //   .HasForeignKey(tm => new { tm.Id, tm.MemberId });
        //modelBuilder.Entity<Employee>()
        //    .HasKey(e => e.Id);

        //modelBuilder.Entity<Team>()
        //    .HasKey(te => te.Id);

        //modelBuilder.Entity<Team>()
        //     .HasMany(t => t.TeamMembers)
        //     .WithOne(tm => tm.Team)
        //     .HasForeignKey(tm => tm.TeamId);

        //////modelBuilder.Entity<Team>()
        //////   .HasMany(t => t.TeamMembers)
        //////   .WithOne(tm => tm.Team)
        //////   .HasForeignKey(tm => tm.TeamId);

        //modelBuilder.Entity<Team>()
        //    .HasMany(t => t.Employees)
        //    .WithOne(tm => tm.Team)
        //    .HasForeignKey(tm => tm.TeamId);

        //modelBuilder.Entity<TeamMember>()
        //    .HasKey(tm => tm.Id);

        //modelBuilder.Entity<TeamMember>()
        //    .HasOne(tm => tm.Team);
        //    //.WithMany(tm => tm.)
        //    //.HasForeignKey(tm => tm.TeamId);

        //modelBuilder.Entity<TeamMember>()
        //    .HasOne(tm => tm.Team)
        //    .WithMany(t => t.TeamMembers)
        //    .HasForeignKey(tm => tm.TeamId);

        //base.OnModelCreating(modelBuilder);

        // //Configure the one - to - many relationship between Team and TeamMember
        // modelBuilder.Entity<Team>()
        //     .HasMany(t => t.TeamMembers)
        //     .WithOne(tm => tm.Team)
        //     .HasForeignKey(tm => tm.TeamId);

        // // Configure the one-to-many relationship between Employee and TeamMember
        // modelBuilder.Entity<Employee>()
        //     .HasMany(e => e.TeamMembers)
        //     .WithOne(tm => tm.Employee)

        //     .HasForeignKey(tm => tm.EmployeeId);
        //// Configure Manager relationships if needed
        // modelBuilder.Entity<TeamManager>()
        //     .HasMany(m => m.TeamMembers)
        //     .WithOne(tm => tm.Manager)
        //     .HasForeignKey(tm => tm.EmployeeId);

        // modelBuilder.Entity<TeamManager>()
        // .HasOne(tm => tm.Team)
        // .WithMany(t => t.TeamManagers)
        // .HasForeignKey(tm => tm.TeamId)
        // .OnDelete(DeleteBehavior.Restrict); // Define your delete behavior as per your requirement

        // modelBuilder.Entity<TeamManager>()
        //     .HasMany(tm => tm.Teams)
        //     .WithOne()
        //     .HasForeignKey(tm => tm.TeamId)
        //     .OnDelete(DeleteBehavior.Restrict); // Define your delete behavior as per your requirement

        //Other configurations for your entities...

        //Ignore any properties that are not needed for EF Core context
        //modelBuilder.Entity<Employee>().Ignore(e => e.Team);
//    }
//}







//using Microsoft.EntityFrameworkCore;
//using OrganizationETMCreation.Models;

//namespace OrganizationETMCreation.Data
//{
//    public class DataContext : DbContext
//    {
//        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

//        public DbSet<Employee> Employees { get; set; }
//        public DbSet<Team> Teams { get; set; }
//        public DbSet<TeamMember> TeamMembers { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//modelBuilder.Entity<Employee>()
//    .HasKey(e => e.Id);

//modelBuilder.Entity<Team>()
//    .HasKey(te => te.Id);

//modelBuilder.Entity<Team>()
//   .HasOne(te => te.Employee)
//   .WithMany(e => e.Teams)
//   .HasForeignKey(te => te.EmployeeId);

////modelBuilder.Entity<Team>()
////    .HasOne(te => te.Member)
////    .WithMany(t => t.Teams)
////    .HasForeignKey(te => te.MemberId);

//modelBuilder.Entity<TeamMember>()
//    .HasKey(tm => tm.Id);

//modelBuilder.Entity<TeamMember>()
//    .HasOne(tm => tm.Employee)
//    .WithMany(e => e.TeamMembers)
//    .HasForeignKey(tm => tm.EmployeeId);

//modelBuilder.Entity<TeamMember>()
//    .HasOne(tm => tm.Team)
//    .WithMany(t => t.TeamMembers)
//    .HasForeignKey(tm => tm.TeamId);

//base.OnModelCreating(modelBuilder);
//        }
//    }
//}




















//using Microsoft.EntityFrameworkCore;
//using OrganizationETMCreation.Models;

//namespace OrganizationETMCreation.Data
//{
//    public class DataContext : DbContext
//    {
//        public DataContext(DbContextOptions<DataContext> options) : base(options)
//        {
//        }

//public DbSet<Employee> Employees { get; set; }
//public DbSet<Team> Teams { get; set; }
//public DbSet<TeamMember> TeamMembers { get; set; }

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Employee>()
//        .HasKey(e => e.Id);

//    modelBuilder.Entity<Team>()
//        .HasKey(t => t.Id);

//    modelBuilder.Entity<TeamMember>()
//        .HasKey(tm => tm.Id);

//    modelBuilder.Entity<TeamMember>()
//        .HasOne(tm => tm.Employee)
//        .WithMany(e => e.TeamMembers)
//        .HasForeignKey(tm => tm.EmployeeId);

//    modelBuilder.Entity<TeamMember>()
//        .HasOne(tm => tm.Team)
//        .WithMany(t => t.TeamMembers)
//        .HasForeignKey(tm => tm.TeamId);

//    base.OnModelCreating(modelBuilder);
//}
//    }
//}
