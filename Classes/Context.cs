using Microsoft.EntityFrameworkCore;

class cdvContext:DbContext{
    public DbSet<department> department{get;set;}

    public cdvContext(){
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        object value = optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123");
    }

}