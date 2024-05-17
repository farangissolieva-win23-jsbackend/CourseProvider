//using Infrastructure.Data.Contexts;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;

//namespace Infrastructure.Factories;

//public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
//{
//    public DataContext CreateDbContext(string[] args)
//    {
//        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
//        optionsBuilder.UseSqlServer("Server=tcp:sql-server-silicon.database.windows.net,1433;Initial Catalog=AccountDatabase;Persist Security Info=False;User ID=sqlAdmin;Password=Blessme!1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

//        return new DataContext(optionsBuilder.Options);
//    }
//}
