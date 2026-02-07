using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;


namespace MyWebApp.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

    public DbSet<Friend> Friends{get;set;}

    public DbSet<Transaction> Tranactions{get;set;}





}