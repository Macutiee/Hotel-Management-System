using Microsoft.EntityFrameworkCore;
using HMS.DAL.Models;

namespace HMS.DAL;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<HousekeepingTask> HousekeepingTasks { get; set; }
    public DbSet<RevenueReport> RevenueReports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Data Source=FX504GE;Initial Catalog=HMS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed roles
        modelBuilder.Entity<Role>().HasData(
            new Role { RoleID = 1, RoleName = "SuperAdmin" },
            new Role { RoleID = 2, RoleName = "Admin" },
            new Role { RoleID = 3, RoleName = "Reception" },
            new Role { RoleID = 4, RoleName = "Housekeeper" }
        );

        string superAdminPass = BCrypt.Net.BCrypt.HashPassword("123456");
        string adminPass = BCrypt.Net.BCrypt.HashPassword("123456");
        string receptionPass = BCrypt.Net.BCrypt.HashPassword("123456");
        string housekeeperPass = BCrypt.Net.BCrypt.HashPassword("123456");

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserID = 1,
                Username = "superadmin01",
                PasswordHash = superAdminPass,
                FullName = "Loan Ngo Thi Bao",
                RoleID = 1
            },
            new User
            {
                UserID = 2,
                Username = "admin01",
                PasswordHash = adminPass,
                FullName = "Bao Tran Do Nguyen",
                RoleID = 2
            },
            new User
            {
                UserID = 3,
                Username = "reception01",
                PasswordHash = receptionPass,
                FullName = "Nhi Nguyen Thi Thu",
                RoleID = 3
            },
            new User
            {
                UserID = 4,
                Username = "housekeeper01",
                PasswordHash = housekeeperPass,
                FullName = "Y Mai Nhu",
                RoleID = 4
            }
        );
    }
}