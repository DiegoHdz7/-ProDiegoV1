using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProDiegoV1.EntityFrameworkCore
{
    public static class ProDiegoV1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProDiegoV1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProDiegoV1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
