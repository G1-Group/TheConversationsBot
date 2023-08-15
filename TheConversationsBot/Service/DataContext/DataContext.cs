using Microsoft.EntityFrameworkCore;
using TheConversationsBot.Domain.Enums;
using TheConversationsBot.Domain.Models;


namespace TheConversationsBot.Service.DataContext;

public class DataContext : DbContext
{
    public DataContext()
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        string connectionString = "Host=localhost; Port=5432; Database=Conversation; username=postgres; password=null";

        optionsBuilder
            .UseNpgsql(connectionString);
        
        base.OnConfiguring(optionsBuilder);
        
    }
    
}